using EduHomeAspNetProject.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.AdminPanel.ViewModels
{
    public class AdminRegisterVM
    {
        [Required, StringLength(100)]
        public string FullName { get; set; }
        [Required, StringLength(20)]
        public string Username { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public List<RoleVM> Roles { get; set; }
        public string Role { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
