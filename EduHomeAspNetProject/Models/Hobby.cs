using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<TeacherHobby> TeacherHobbies { get; set; }
    }
}
