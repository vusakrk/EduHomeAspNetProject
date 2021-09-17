﻿using Microsoft.AspNetCore.Http;
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
        [Required, StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Required]
        public string Place { get; set; }
        [NotMapped,Required]
        public IFormFile Photo { get; set; }
        public bool HasDeleted { get; set; }
        public int EventDetailId { get; set; }
        public EventDetail EventDetail { get; set; }
        public virtual ICollection<SpeakerEvent> SpeakerEvents { get; set; }
        
    }
}
