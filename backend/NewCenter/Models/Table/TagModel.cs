﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NewCenter.Models
{
    public class TagModel:BaseModel
    {
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
