using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class NewsModel:BaseModel
    {
        [Required]
        [Column(TypeName ="nvarchar(Max)")]
        public string Url { get; set; }

        [Column(TypeName = "nvarchar(Max)")]
        public string ThumbNail { get; set; }

        [Column(TypeName = "nvarchar(Max)")]
        public string Title { get; set; }

        //ref Source table
        [Required]
        public int RefSourceId { get; set; }
    }
}
