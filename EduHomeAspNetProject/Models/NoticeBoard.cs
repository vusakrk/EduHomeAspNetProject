﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Date { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        
    }
}
