using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class ContactMessage
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Name { get; set; }
        [Required,StringLength(255),DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Subject { get; set; }
        [Required,StringLength(500)]
        public string Message { get; set; }
    }
}
