using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required,StringLength(150)]
        public string Image { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(100)]
        public string Profession { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
    }
}
