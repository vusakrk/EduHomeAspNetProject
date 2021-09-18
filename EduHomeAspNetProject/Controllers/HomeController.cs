using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders=_context.Sliders.ToList(),
                Services=_context.Services.ToList(),
                About=_context.Abouts.FirstOrDefault(),
                NoticeBoards = _context.NoticeBoards.OrderByDescending(b=>b.Id).ToList(),
                NoticeVideo = _context.NoticeVideos.FirstOrDefault(),
                Events= _context.Events.OrderByDescending(e=>e.Id).Take(2).ToList(),
            };

            return View(homeVM);
        }
    }
}
