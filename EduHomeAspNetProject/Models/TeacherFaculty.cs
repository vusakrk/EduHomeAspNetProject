using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class TeacherFaculty
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
