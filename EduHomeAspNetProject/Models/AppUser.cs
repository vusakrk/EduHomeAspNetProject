using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
        public bool HasDeleted { get; set; }
        public AppUser()
        {
            HasDeleted = false;
        }
    }
}
