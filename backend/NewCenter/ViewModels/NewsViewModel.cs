using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.ViewModels
{
    public class NewsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Thumbnail { get; set; }
        public string Url { get; set; }
        public DateTime? pubDate { get; set; }
        public string Logo { get; set; }
        public int UpvoteCount { get; set; }
        public int CommentCount { get; set; }
    }
}
