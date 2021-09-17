using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Controllers
{
    public class HomeController : Controller
    {
        public AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Sliders = await _context.Sliders.ToListAsync(),
                HeaderContact = _context.HeaderContacts.FirstOrDefault(),
                BrandLogo = _context.BrandLogo.FirstOrDefault(),
                ServiceArea = _context.ServiceAreas.FirstOrDefault(),
                ViewCourse = _context.ViewCourses.FirstOrDefault(),
                Courses = _context.Courses.OrderByDescending(p => p.Id).Take(3).ToList(),
                CourseDetails = _context.CourseDetails.ToList(),

            };
            return View(homeVM);
        }
    }
}
