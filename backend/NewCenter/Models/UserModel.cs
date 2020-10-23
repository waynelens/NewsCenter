using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class UserModel:BaseModel
    {
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Column(TypeName ="nvarchar(Max)")]
        public string Password { get; set; }

        [Column(TypeName ="nvarchar(Max)")]
        public string Avator { get; set; }

        // ref Permission table
        [Required]
        public int RefPermissionId { get; set; }
    }
}
