using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class TeacherHobbie
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int HobbieId { get; set; }
        public Teacher Teacher { get; set; }
        public Hobbie Hobbie { get; set; }
    }
}
