using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewCenter.DataAccess;
using NewCenter.DataAccess.Repository;
using NewCenter.Models;

namespace NewCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly NewsRepository _repo;
       
        public NewsController(NewsRepository Repo)
        {
            _repo = Repo;
        }

        // GET: api/News
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NewsModel>>> GetNews()
        {
            return await _context.News.ToListAsync();
        }

        // GET: api/News/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NewsModel>> GetNewsModel(int id)
        {
            var newsModel = await _context.News.FindAsync(id);

            if (newsModel == null)
            {
                return NotFound();
            }

            return newsModel;
        }

        // PUT: api/News/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNewsModel(int id, NewsModel newsModel)
        {
            if (id != newsModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(newsModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsModelExists(id))
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

        // POST: api/News
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NewsModel>> PostNewsModel(NewsModel newsModel)
        {
            _context.News.Add(newsModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNewsModel", new { id = newsModel.Id }, newsModel);
        }

        // DELETE: api/News/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<NewsModel>> DeleteNewsModel(int id)
        {
            var newsModel = await _context.News.FindAsync(id);
            if (newsModel == null)
            {
                return NotFound();
            }

            _context.News.Remove(newsModel);
            await _context.SaveChangesAsync();

            return newsModel;
        }

        private bool NewsModelExists(int id)
        {
            return _context.News.Any(e => e.Id == id);
        }
    }
}
