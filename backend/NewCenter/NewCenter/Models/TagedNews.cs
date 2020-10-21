using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class TagedNews:BaseModel
    {
        // Ref News
        public int RefNewsId { get; set; }
        // Ref Tag
        public int RefTagId { get; set; }
    }
}
