using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.DataTransfer.Request
{
    public class NewsRequest
    {
        public class LatestNews
        {
            public int sourceId { get; set; }
            public int batch { get; set; }
        }
    }
}
