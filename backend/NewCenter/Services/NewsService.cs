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
    public class NewsService:INewsService
    {
        public NewsService()
        {
           
        }

        // 回傳複數文章資訊
        public XmlNodeList parseRss(string rssUrl) 
        {
            WebRequest req = WebRequest.Create(rssUrl);
            WebResponse res = req.GetResponse();
            Stream rssStream = res.GetResponseStream();
            XmlDocument rssDoc = new XmlDocument();
            rssDoc.Load(rssStream);

            return rssDoc.SelectNodes("rss/channel/item");
        }
    }
}
