using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required,StringLength(255)]
        public string Name { get; set; }
        [Required,StringLength(300)]
        public string Description { get; set; }
    }
}
