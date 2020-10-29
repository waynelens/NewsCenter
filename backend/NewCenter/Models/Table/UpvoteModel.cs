using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class UpvoteModel:BaseModel
    {
        // Ref User
        [Required]
        public int RefUserId { get; set; }
        // Ref News
        [Required]
        public int RefNewsId { get; set; }
    }
}
