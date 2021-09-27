using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Slider
    {
        
        public int Id { get; set; }
        [StringLength(200)]
        public string Title { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        [Required,StringLength(255)]
        public string Image { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
        [NotMapped, Required]
        public IFormFile[] Photos { get; set; }

    }
}
