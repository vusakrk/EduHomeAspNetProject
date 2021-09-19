using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class TeacherDegree
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int DegreeId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Degree Degree { get; set; }
    }
}
