using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class SourceModel:BaseModel
    {
        // example: hackernews/latestpost
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(Max)")]
        public string Logo { get; set; }

        [Required]
        [Column(TypeName ="nvarchar(Max)")]
        public string RssFeed { get; set; }


    }
}
