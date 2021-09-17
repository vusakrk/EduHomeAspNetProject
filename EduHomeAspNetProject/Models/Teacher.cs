using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [Required,StringLength(50)]
        public string Surname { get; set; }
        [Required]
        public int Age { get; set; }
        [Required,StringLength(100)]
        public string Profession { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
        public string Facebook { get; set; }
        public string Vimeo { get; set; }
        public string Twitter { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Skype { get; set; }
        public bool HasDeleted { get; set; }
        public string Image { get; set; }
        public int TeacherDetailId { get; set; }
        public TeacherDetail TeacherDetail { get; set; }
        public int TeacherSkillId { get; set; }
        public TeacherSkill TeacherSkill { get; set; }

    }
}
