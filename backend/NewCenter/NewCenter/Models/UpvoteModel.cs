using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class UpvoteModel:BaseModel
    {
        // Ref User
        public int RefUserId { get; set; }
        // Ref News
        public int RefNewsId { get; set; }
    }
}
