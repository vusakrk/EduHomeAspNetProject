using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class BlogDetail
    {
        public int Id { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }
        public string Content4 { get; set; }
        public bool HasDeleted { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
