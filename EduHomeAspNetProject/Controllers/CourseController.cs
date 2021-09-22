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
    public class CourseController : Controller
    {
        private AppDbContext _context;
        public CourseController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseVM courseVM = new CourseVM
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                Courses = _context.Courses.OrderByDescending(p => p.Id).Take(9).ToList(),
                CourseDetails = _context.CourseDetails.ToList(),
                CourseFeatures = _context.CourseFeatures.ToList()
            
            };
            return View(courseVM);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Course course = await _context.Courses.FindAsync(id);
            if (course == null)
                return NotFound();
            CourseDetailVM detailVM = new CourseDetailVM
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                Course = course,
                CourseDetails = _context.CourseDetails.ToList(),
                Blogs = _context.Blogs.OrderByDescending(p => p.Id).Take(5).ToList(),
                CourseFeatures = _context.CourseFeatures.OrderByDescending(p => p.Id).ToList()

            };
            return View(detailVM);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detail(CourseDetailVM detailVM)
        {
            ContactMessage contactMessage = new ContactMessage
            {
                Name = detailVM.ContactMessage.Name,
                Email = detailVM.ContactMessage.Email,
                Subject = detailVM.ContactMessage.Subject,
                Message = detailVM.ContactMessage.Message
            };
            _context.ContactMessages.Add(contactMessage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Detail));
        }
        public async Task<IActionResult>Search(string key)
        {
            var model = _context.Courses.Where(p => p.Name.Contains(key)).Select(p => new Course { 
            Id = p.Id,
            Name = p.Name
            }).Take(6);
            return RedirectToAction(nameof(Detail));
        }
    }
}
