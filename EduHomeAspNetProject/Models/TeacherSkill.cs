using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class TeacherSkill
    {
        public int Id { get; set; }
        public int Language { get; set; }
        public int TeamLeader { get; set; }
        public int Development { get; set; }
        public int Design { get; set; }
        public int Innovation { get; set; }
        public int Communication { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
