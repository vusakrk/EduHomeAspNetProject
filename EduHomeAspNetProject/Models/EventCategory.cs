﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class EventCategory
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
