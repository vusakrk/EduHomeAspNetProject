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
        [Required,StringLength(100)]
        public string FullName { get; set; }
        [Required,StringLength(255)]
        public string Image { get; set; }
        public int SkillId { get; set; }
        public int FacultyId { get; set; }
        public virtual TeacherInfo TeacherInfo { get; set; }
        public virtual TeacherSkill TeacherSkill { get; set; }
        public virtual TeacherFaculty TeacherFaculty { get; set; }
        public List<TeacherHobbie> TeacherHobbies { get; set; }
        public List<TeacherDegree> TeacherDegrees { get; set; }
        [Required,NotMapped]
        public IFormFile Photo { get; set; }
    }
}
