using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string FooterPhone1 { get; set; }
        [StringLength(50)]
        public string FooterPhone2 { get; set; }
        [Required,StringLength(50)]
        public string Logo { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        [StringLength(50)]
        public string Facebook { get; set; }
        [StringLength(50)]
        public string Pinterest { get; set; }
        [StringLength(50)]
        public string Vimeo { get; set; }
        [StringLength(50)]
        public string Twitter { get; set; }
        [StringLength(255)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(50)]
        public string Website { get; set; }
    }
}
