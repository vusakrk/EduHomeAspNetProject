using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.ViewModels
{
    public class ContactSubscribeVM
    {
        public List<Models.ContactMessage> ContactMessages { get; set; }
        public List<Models.Subscribe> Subscribes { get; set; }
        public string Role { get; set; }
    }
}
