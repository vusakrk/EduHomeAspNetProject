using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class AboutVM
    {
        public string BgImage { get; set; }
        public About About { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<TeacherDetail> TeacherDetails { get; set; }
    }
}
