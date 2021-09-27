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
    public class SubscribeController : Controller
    {
        private AppDbContext _context { get; }
        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Subscribe> subscribes = _context.Subscribes.ToList();
            return View(subscribes);
        }
    }
}
