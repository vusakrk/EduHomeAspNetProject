using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class SpeakerEvent
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public virtual Event Event { get; set; }
        public int SpeakerId { get; set; }
        public virtual Speaker Speaker { get; set; }
    }
}
