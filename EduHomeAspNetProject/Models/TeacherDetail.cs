using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class TeacherDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Experience { get; set; }
        public string Faculty { get; set; }
        public bool HasDeleted { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
