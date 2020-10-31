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

        // GET: api/News/LatestNews/1
        // 提取前30篇文章，瀑布流
        // batch 代表第幾批文章
        [HttpGet("{batch}")]
        public IActionResult LatestNews(int batch)
        {
            List<NewsResponse.LatestNews> res = new List<NewsResponse.LatestNews>();

            var latest30News = _newsrepo.ReadAll().Where(x => x.IsDelete == false).OrderByDescending(x => x.pubDate).Take(batch * 30);
            foreach(var news in latest30News)
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

        // GET: api/News/LatestNews/5
        // 取得特定sourceId的最新文章
        //[HttpGet("{id}")]
        //public IActionResult LatestNews(int sourceId)
        //{ 
        //    DateTime today = DateTime.Today.AddDays(-1);
        //    DateTime tomorrow = DateTime.Today;
        //    List<NewsResponse> res = new List<NewsResponse>();

        //    var allNews = _newsrepo.ReadAll().Where(x => x.IsDelete == false && x.RefSourceId == sourceId).AsEnumerable<NewsModel>();
        //    var latestNews = allNews.Where(x => DateTime.Compare(today, (DateTime)x.pubDate) < 0 && DateTime.Compare(tomorrow, (DateTime)x.pubDate) > 0);
        //    foreach (var news in latestNews)
        //    {
        //        NewsResponse resPart = new NewsResponse()
        //        {
        //            Id = news.Id,
        //            Title = news.Title,
        //            Thumbnail = news.ThumbNail,
        //            Url = news.Url,
        //            pubDate = news.pubDate,
        //            Logo = _sourcerepo.Read(x => x.Id == news.RefSourceId).Logo,
        //            UpvoteCount = _upvoterepo.ReadAll().Where(x => x.RefNewsId == news.Id).Count(),
        //            CommentCount = _commentrepo.ReadAll().Where(x => x.RefNewsId == news.Id).Count(),
        //        };
        //        res.Add(resPart);
        //    }

        //    return Ok(res);
        //}

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
