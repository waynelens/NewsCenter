using CodeHollow.FeedReader;
using CodeHollow.FeedReader.Feeds;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.CodeAnalysis.CSharp;
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
            IEnumerable<SourceModel> allSources = _sourceRepo.ReadAll().Where(x => x.IsDelete == false && x.Name != "Reviewing").AsEnumerable<SourceModel>();
            IEnumerable<NewsModel> allNews = _newsRepo.ReadAll().AsEnumerable<NewsModel>();
            List<NewsModel> willAddNews = new List<NewsModel>();
            foreach (SourceModel source in allSources)
            {
                var feed = FeedReader.Read(source.RssFeed);
                if (feed.Type == FeedType.Rss_2_0)
                {
                    var rss20Feed = (Rss20Feed)feed.SpecificFeed;
                    foreach (var Item in rss20Feed.Items)
                    {
                        var rss20Item = (Rss20FeedItem)Item;
                        NewsModel oneNews = new NewsModel()
                        {
                            CreatTime = DateTime.Now,
                            IsDelete = false,
                            RefCreatorId = 3,
                            Url = rss20Item.Link,
                            ThumbNail = "nothing",
                            Title = rss20Item.Title,
                            pubDate = String.IsNullOrEmpty(rss20Item.PublishingDateString) ? DateTime.Now : rss20Item.PublishingDate,
                            RefSourceId = source.Id
                        };
                        if(allNews.Where(x => x.Url == oneNews.Url).Count() == 0)
                        {
                            willAddNews.Add(oneNews);
                        }
                    }
                }
                else if (feed.Type == FeedType.Atom)
                {
                    var atomFeed = (AtomFeed)feed.SpecificFeed;
                    foreach(var Item in atomFeed.Items)
                    {
                        var atomItem = (AtomFeedItem)Item;
                        NewsModel oneNews = new NewsModel()
                        {
                            CreatTime = DateTime.Now,
                            IsDelete = false,
                            RefCreatorId = 3,
                            Url = atomItem.Links.Last().ToString(),
                            ThumbNail = "nothing",
                            Title = atomItem.Title,
                            pubDate = String.IsNullOrEmpty(atomItem.PublishedDateString) ? DateTime.Now : atomItem.PublishedDate,
                            RefSourceId = source.Id
                        };
                        if (allNews.Where(x => x.Url == oneNews.Url).Count() == 0)
                        {
                            willAddNews.Add(oneNews);
                        }
                    }
                }
                else if(feed.Type == FeedType.MediaRss)
                {
                    var mediaFeed = (MediaRssFeed)feed.SpecificFeed;
                    foreach(var item in mediaFeed.Items)
                    {
                        var mediaItem = (MediaRssFeedItem)item;
                        NewsModel oneNews = new NewsModel()
                        {
                            CreatTime = DateTime.Now,
                            IsDelete = false,
                            RefCreatorId = 3,
                            Url = mediaItem.Link,
                            ThumbNail = "nothing",
                            Title = mediaItem.Title,
                            pubDate = String.IsNullOrEmpty(mediaItem.PublishingDateString) ? DateTime.Now : mediaItem.PublishingDate,
                            RefEditorId = source.Id
                        };
                        if (allNews.Where(x => x.Url == oneNews.Url).Count() == 0)
                        {
                            willAddNews.Add(oneNews);
                        }
                    }
                }
            }
            _newsRepo.Create(willAddNews);
        }

        public bool urlIsRss(string rssUrl)
        {
            try
            {
                var feed = FeedReader.Read(rssUrl);
                return Enum.IsDefined(typeof(FeedType), feed.Type);
            }
            catch(Exception e)
            {
                return false;
            }
        }

    }
}
