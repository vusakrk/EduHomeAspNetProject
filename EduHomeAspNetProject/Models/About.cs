using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Title { get; set; }
        [Required,StringLength(350)]
        public string DescOne { get; set; }
        [Required, StringLength(350)]
        public string DescTwo { get; set; }
        [Required,StringLength(100)]
        public string Image { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }

    }
}
