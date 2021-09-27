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
        public Teacher Teacher { get; set; }
        public Degree Degree { get; set; }
    }
}
