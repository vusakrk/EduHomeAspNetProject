using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Controllers
{
    [Area("AdminPanel")]
    public class AboutController : Controller
    {
        private AppDbContext _context { get;}
        public AboutController(AppDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Index()
        {
            
            HomeVM homeVM = new HomeVM()
            {
                About = _context.Abouts.FirstOrDefault(),
                NoticeVideo = _context.NoticeVideos.FirstOrDefault(),
            };
            return View(homeVM);
        }
    }
}
