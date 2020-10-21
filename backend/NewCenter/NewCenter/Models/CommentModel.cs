using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class CommentModel:BaseModel
    {
        public string Content { get; set; }
        
        // Ref User
        // Ref News
        public int RefUserId { get; set; }
        public int RefNewsId { get; set; }
    }
}
