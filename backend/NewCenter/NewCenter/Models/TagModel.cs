using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class TagModel:BaseModel
    {
        [StringLength(50)]
        public string Name { get; set; }
    }
}
