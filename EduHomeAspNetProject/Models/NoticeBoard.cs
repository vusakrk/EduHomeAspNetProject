using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required, StringLength(200)]
        public string Content { get; set; }
    }
}
