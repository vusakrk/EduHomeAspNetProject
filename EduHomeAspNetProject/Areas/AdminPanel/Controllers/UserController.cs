using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class UserController : Controller
    {
        private AppDbContext _context { get; }
        public UserController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<AppUser> users = _context.Users.ToList();
            return View(users);
        }
    }
}
