using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class TeacherInfo
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Specialty { get; set; }
        [Required,StringLength(500)]
        public string AboutMe { get; set; }
        public int Experience { get; set; }
        [Required,StringLength(100)]
        public string Phone { get; set; }
        public string Skype { get; set; }
        public string Facebook { get; set; }
        public string Pinterest { get; set; }
        public string Vimeo { get; set; }
        public string Twitter { get; set; }
        public string TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
