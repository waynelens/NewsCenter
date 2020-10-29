using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class CommentModel:BaseModel
    {
        [Required]
        [Column(TypeName="nvarchar(Max)")]
        public string Content { get; set; }
        
        // Ref User
        // Ref News
        [Required]
        public int RefUserId { get; set; }
        [Required]
        public int RefNewsId { get; set; }
    }
}
