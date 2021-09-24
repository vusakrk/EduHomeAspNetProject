using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(150)]
        public string Image { get; set; }
        public string Definition { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string StartInterval { get; set; }
        public string EndInterval { get; set; }
        [StringLength(150)]
        public string Place { get; set; }
        [Required]
        public string Content { get; set; }
        public int EventCategoryId { get; set; }
        //public EventCategory EventCategory { get; set; }
        public EventComment EventComment { get; set; }
        public List<EventSpeaker> EventSpeakers { get; set; }
        [Required, NotMapped]
        public IFormFile Photo { get; set; }
    }
}
