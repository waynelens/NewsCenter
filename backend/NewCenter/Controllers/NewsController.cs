using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
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
    public class NewsController : ControllerBase
    {
        private readonly DAOContext _context;
        private readonly NewsRepository _newsrepo;
        private readonly SourceRepository _sourcerepo;
        private readonly UpvoteRepository _upvoterepo;
        private readonly CommentRepository _commentrepo;


        public NewsController(DAOContext Context)
        {
            _context = Context;
            _newsrepo = new NewsRepository(_context);
            _sourcerepo = new SourceRepository(_context);
            _upvoterepo = new UpvoteRepository(_context);
            _commentrepo = new CommentRepository(_context);
        }

        // Post: api/News/LatestNews
        // 提取前30篇文章，瀑布流
        // 根據是否有給sourceId，決定是否給特定source文章
        // batch 代表第幾批文章
        [HttpPost]
        public IActionResult LatestNews(NewsRequest.LatestNews req)
        {
            List<NewsResponse.LatestNews> res = new List<NewsResponse.LatestNews>();
            IQueryable<NewsModel> latestNews = null;

            if(req.sourceId == 0)
            {
                latestNews = _newsrepo.ReadAll().Where(x => x.IsDelete == false).OrderByDescending(x => x.pubDate).Take(req.batch * 8).Skip((req.batch - 1) * 8);
            }
            else
            {
                latestNews = _newsrepo.ReadAll().Where(x => x.IsDelete == false && x.RefSourceId == req.sourceId).OrderByDescending(x => x.pubDate).Take(req.batch * 8).Skip((req.batch - 1) * 8);
            }

            foreach(NewsModel news in latestNews)
            {
                NewsResponse.LatestNews resPart = new NewsResponse.LatestNews()
                {
                    Id = news.Id,
                    Title = news.Title,
                    Thumbnail = news.ThumbNail,
                    Url = news.Url,
                    pubDate = news.pubDate,
                    Logo = _sourcerepo.Read(x => x.Id == news.RefSourceId).Logo,
                    UpvoteCount = _upvoterepo.ReadAll().Where(x => x.RefNewsId == news.Id).Count(),
                    CommentCount = _commentrepo.ReadAll().Where(x => x.RefNewsId == news.Id).Count(),
                };
                res.Add(resPart);
            }

            return Ok(res);
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
