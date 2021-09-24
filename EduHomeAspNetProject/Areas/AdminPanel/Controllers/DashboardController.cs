using EduHomeAspNetProject.Areas.ViewModels;
using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Net.Http;

namespace EduHomeAspNetProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController : Controller
    {
        private AppDbContext _context { get; }
        private UserManager<AppUser> _userManager { get; }
        public DashboardController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
