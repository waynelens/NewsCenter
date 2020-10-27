using NewCenter.DataAccess;
using NewCenter.DataAccess.Repository;
using NewCenter.Models;
using NewCenter.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace NewCenter.Services
{
    // parse rss2.0
    public class RssService : IRssService
    {
        private readonly DAOContext _context;
        private readonly SourceRepository _sourceRepo;
        private readonly NewsRepository _newsRepo;

        public RssService(DAOContext Context)
        {
            _context = Context;
            _sourceRepo = new SourceRepository(_context);
            _newsRepo = new NewsRepository(_context);
        }

        public void updateDailyNews()
        {
            IEnumerable<SourceModel> allSources = _sourceRepo.ReadAll().AsEnumerable<SourceModel>();
            IEnumerable<NewsModel> allNews = _newsRepo.ReadAll().AsEnumerable<NewsModel>();
            List<NewsModel> willAddNews = new List<NewsModel>();
            foreach (SourceModel source in allSources)
            {
                XmlNodeList oneSourceArticles = parseRss(source.RssFeed);
                foreach (XmlNode article in oneSourceArticles)
                {
                    NewsModel parseArticle = parseNode(article,source.Id);
                    if(allNews.Where(x => x.Url == parseArticle.Url).Count() == 0)
                    {
                        willAddNews.Add(parseArticle);
                    }
                }
            }
            _newsRepo.Create(willAddNews);
        }

        // 回傳複數文章節點
        private XmlNodeList parseRss(string rssUrl)
        {
            WebRequest req = WebRequest.Create(rssUrl);
            WebResponse res = req.GetResponse();
            Stream rssStream = res.GetResponseStream();
            XmlDocument rssDoc = new XmlDocument();
            rssDoc.Load(rssStream);

            return rssDoc.SelectNodes("rss/channel/item");
        }

        // 解析單一節點
        private NewsModel parseNode(XmlNode Node,int sourceid)
        {
            TimeService timeParser = new TimeService();
            DateTime pubDate;
            try
            {
                pubDate = timeParser.parseTimetoUTC(Node.SelectSingleNode("pubDate").InnerText);
            }
            catch(Exception e)
            {
                // 如果parse不成，之後要寫log
                // 因為要增加parse的規則
                pubDate = DateTime.Now;
            }
            return new NewsModel()
            {
                CreatTime = DateTime.Now,
                IsDelete = false,
                RefCreatorId = 3,
                Url = Node.SelectSingleNode("link").InnerText,
                ThumbNail = "nothing",
                Title = Node.SelectSingleNode("title").InnerText,
                pubDate = pubDate,
                RefSourceId = sourceid
            };
        }
    }
}
