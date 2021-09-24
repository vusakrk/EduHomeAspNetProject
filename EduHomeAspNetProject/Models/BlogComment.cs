using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class BlogComment
    {
        public int Id { get; set; }
        [Required,StringLength(500)]
        public string Message { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
