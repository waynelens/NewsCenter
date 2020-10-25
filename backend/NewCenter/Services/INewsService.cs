using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace NewCenter.Services
{
    public interface INewsService
    {
        public XmlNodeList parseRss(string rssUrl);
    }
}
