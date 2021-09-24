﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}
