using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Hobbie
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        public List<TeacherHobbie> TeacherHobbies { get; set; }
    }
}
