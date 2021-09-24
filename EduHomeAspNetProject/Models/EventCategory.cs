using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Event> Events { get; set; }
        public int Count { get; set; }
    }
}
