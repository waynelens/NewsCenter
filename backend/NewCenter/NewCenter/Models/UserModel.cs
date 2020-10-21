using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class UserModel:BaseModel
    {
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        // max長度
        public string Password { get; set; }

        [StringLength(50)]
        public string Avator { get; set; }

        // ref Permission table
        public int RefPermissionId { get; set; }
    }
}
