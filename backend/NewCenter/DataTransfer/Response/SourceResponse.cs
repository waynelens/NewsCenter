using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.ViewModels
{
    public class SourceResponse
    {
        public class Get
        {
            public int Id { get; set; }
            public string Logo { get; set; }
            public string Name { get; set; }
            public string RssFeed { get; set; }
        }
    }
}
