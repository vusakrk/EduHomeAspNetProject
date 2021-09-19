﻿using System.ComponentModel.DataAnnotations;

namespace EduHomeAspNetProject.ViewModels
{
    public class RegisterVM
    {
[Required,StringLength(100)]
        public string Fullname { get; set; }
        [Required,StringLength(50)]
        public string Username { get; set; }
        [Required,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string Password { get; set; }
        [Required,DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
