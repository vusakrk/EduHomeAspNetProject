﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class HeaderContact
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Contact { get; set; }
       
    }
}
