using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class EventComment
    {
        public int Id { get; set; }
        [Required,StringLength(500)]
        public string Message { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
