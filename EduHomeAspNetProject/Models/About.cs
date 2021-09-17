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
        [Required]
        public string Image { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
        public string Title { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }

    }
}
