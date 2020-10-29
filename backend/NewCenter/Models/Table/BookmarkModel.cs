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
        public int RefUserId { get; set; }
        // ref News
        [Required]
        public int RefNewsId { get; set; }
    }
}
