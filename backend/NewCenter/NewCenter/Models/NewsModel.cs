using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class NewsModel:BaseModel
    {
        public string Url { get; set; }

        [AllowNull]
        public string ThumbNail { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        //ref Source table
        public int RefSourceId { get; set; }
        
    }
}
