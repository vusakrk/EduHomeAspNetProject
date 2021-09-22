using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class TeacherVM
    {
        public BgImage BgImage { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<TeacherAbout> TeacherAbouts { get; set; }
        public List<TeacherSkill> TeacherSkills { get; set; }
        public List<TeacherState> TeacherStates { get; set; }
        public List<Hobby> Hobbies { get; set; }
        public List<TeacherHobby> TeacherHobbies { get; set; }
    }
}
