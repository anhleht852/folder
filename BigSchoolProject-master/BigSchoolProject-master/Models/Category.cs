﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchoolProject.Models
{
    public class Category
    {
        public byte id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}