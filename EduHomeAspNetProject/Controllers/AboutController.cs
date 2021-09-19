using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Controllers
{
    public class AboutController : Controller
    {
        private AppDbContext _context { get; }
        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            AboutVM aboutVM = new AboutVM()
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                About = _context.Abouts.FirstOrDefault(),
                Testimonials = _context.Testimonials.ToList(),
                NoticeVideo = _context.NoticeVideos.FirstOrDefault(),
                NoticeBoards = _context.NoticeBoards.ToList()
            };
            return View(aboutVM);
        }
    }
}
