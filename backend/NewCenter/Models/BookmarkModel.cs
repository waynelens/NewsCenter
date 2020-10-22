using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class BookmarkModel:BaseModel
    {
        // ref User
        [Required]
        public string RefUserId { get; set; }
        // ref News
        [Required]
        public string RefNewsId { get; set; }
    }
}
