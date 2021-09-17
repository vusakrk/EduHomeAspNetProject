using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class NoticeVideo
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string VideoPopUp { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
    }
}
