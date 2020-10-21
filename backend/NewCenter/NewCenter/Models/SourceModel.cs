using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class SourceModel:BaseModel
    {
        // example: hackernews/latestpost
        [StringLength(50)]
        public string Name { get; set; }
        public string Logo { get; set; }

        public string RssFeed { get; set; }


    }
}
