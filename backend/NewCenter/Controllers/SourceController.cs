using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewCenter.DataAccess;
using NewCenter.DataAccess.Repository;
using NewCenter.DataTransfer.Request;
using NewCenter.Models;
using NewCenter.ViewModels;

namespace NewCenter.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SourceController : ControllerBase
    {
        private readonly DAOContext _context;
        private readonly SourceRepository _sourcerepo;
        public SourceController(DAOContext context)
        {
            _context = context;
            _sourcerepo = new SourceRepository(context);
        }

        // GET: api/Source/GetSources
        [HttpGet]
        public IActionResult GetSources()
        {
            List<SourceResponse> res = new List<SourceResponse>();
            var allSources = _sourcerepo.ReadAll().Where(x => x.IsDelete == false).AsEnumerable<SourceModel>();
            
            foreach(SourceModel source in allSources)
            {
                SourceResponse resPart = new SourceResponse()
                {
                    Id = source.Id,
                    Logo = source.Logo,
                    Name = source.Name,
                    RssFeed = source.RssFeed
                };
                res.Add(resPart);
            }

            return Ok(res);
        }

        // POST: api/Source/PostSource
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public IActionResult PostSource(SourceRequest req)
        {
            return Ok();
        }

        // GET: api/Source/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SourceModel>> GetSourceModel(int id)
        {
            var sourceModel = await _context.Sources.FindAsync(id);

            if (sourceModel == null)
            {
                return NotFound();
            }

            return sourceModel;
        }

        // PUT: api/Source/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSourceModel(int id, SourceModel sourceModel)
        {
            if (id != sourceModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(sourceModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SourceModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        

        // DELETE: api/Source/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<SourceModel>> DeleteSourceModel(int id)
        {
            var sourceModel = await _context.Sources.FindAsync(id);
            if (sourceModel == null)
            {
                return NotFound();
            }

            _context.Sources.Remove(sourceModel);
            await _context.SaveChangesAsync();

            return sourceModel;
        }

        private bool SourceModelExists(int id)
        {
            return _context.Sources.Any(e => e.Id == id);
        }
    }
}
