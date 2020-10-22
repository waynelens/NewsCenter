using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class BaseModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "datetime2(7)")]
        [Required]
        public DateTime CreatTime { get; set; }

        [Column(TypeName = "datetime2(7)")]
        [AllowNull]
        public DateTime EditTime { get; set; }

        [Required]
        public bool IsDelete { get; set; }

        // ref User table
        [Required]
        public int RefCreatorId { get; set; }

        [AllowNull]
        public int RefEditorId { get; set; }
    }
}
