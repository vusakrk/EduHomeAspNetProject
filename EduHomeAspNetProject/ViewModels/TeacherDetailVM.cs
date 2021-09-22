using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class TeacherDetailVM
    {
        public BgImage BgImage { get; set; }
        public Teacher Teacher { get; set; }
        public TeacherState TeacherState { get; set; }
        public TeacherAbout TeacherAbout { get; set; }
        public List<Hobby> Hobbies { get; set; }
        public TeacherSkill TeacherSkill { get; set; }
    }
}
