using EduHomeAspNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewModels
{
    public class ContactVM
    {
        public ContactMessage ContactMessage { get; set; }
        public BgImage BgImage { get; set; }
        public Setting Setting { get; set; }
    }
}
