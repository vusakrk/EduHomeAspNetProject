using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.AdminPanel.ViewModels
{
    public class SliderVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int SliderId { get; set; }
        public Slider Slider { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
