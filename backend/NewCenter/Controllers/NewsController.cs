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
using NewCenter.Repository;
using NewCenter.Services;

namespace NewCenter.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly DAOContext _context;
        private readonly NewsRepository _newsrepo;
        private readonly RssService _service;

        public NewsController(DAOContext Context)
        {
            _context = Context;
            _newsrepo = new NewsRepository(_context);
            _service = new RssService(_context);
        }

        // GET: api/News/GetLatestNews
        [HttpGet]
        public IActionResult LatestNews()
        {
            DateTime today = DateTime.Today.AddDays(-1);
            DateTime tomorrow = DateTime.Today;
            var allNews = _newsrepo.ReadAll().AsEnumerable<NewsModel>();
            var latestNews = allNews.Where(x => DateTime.Compare(today, (DateTime)x.pubDate) < 0 && DateTime.Compare(tomorrow, (DateTime)x.pubDate) > 0);

            return Ok(latestNews);
        }

        //// POST: api/News
        //[HttpPost]
        //public async Task<ActionResult<NewsModel>> PostNewsModel(RssRequestViewModels Rssreq)
        //{
        //    string rssUrl = Rssreq.RssUrl;
        //    XmlNodeList latestArticles = 
        //    _context.News.Add(newsModel);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetNewsModel", new { id = newsModel.Id }, newsModel);
        //}



        //// GET: api/News/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<NewsModel>> GetNewsModel(int id)
        //{
        //    var newsModel = await _context.News.FindAsync(id);

        //    if (newsModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return newsModel;
        //}

        //// PUT: api/News/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutNewsModel(int id, NewsModel newsModel)
        //{
        //    if (id != newsModel.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(newsModel).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!NewsModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}



        //// DELETE: api/News/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<NewsModel>> DeleteNewsModel(int id)
        //{
        //    var newsModel = await _context.News.FindAsync(id);
        //    if (newsModel == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.News.Remove(newsModel);
        //    await _context.SaveChangesAsync();

        //    return newsModel;
        //}

        //private bool NewsModelExists(int id)
        //{
        //    return _context.News.Any(e => e.Id == id);
        //}
    }
}
