using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required, MinLength(33), MaxLength(63)]
        public string Title { get; set; }
        [Required, MaxLength(6)]
        public string Author { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required, MinLength(200)]
        public string Content { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
    }
}
