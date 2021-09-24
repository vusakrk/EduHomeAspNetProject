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
                NoticeBoards = _context.NoticeBoards.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
                Teachers = _context.Teachers.ToList(),
                TeacherAbouts = _context.TeacherAbouts.ToList()
            };
            return View(aboutVM);
        }
        public async Task<IActionResult> Detail(int?id)
        {
            if (id == null)
                return NotFound();
            Course course = await _context.Courses.FindAsync(id);
            if (course == null)
                return NotFound();
            CourseDetailVM courseDetailVM = new CourseDetailVM
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                Course = course,
                CourseDetails = _context.CourseDetails.ToList(),
                Blogs = _context.Blogs.OrderByDescending(p=>p.Id).Take(5).ToList(),
                CourseFeatures = _context.CourseFeatures.ToList()
            };
            return View(courseDetailVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detail(CourseDetailVM courseDetailVM)
        {
            ContactMessage contactMessage = new ContactMessage
            {
                Name = courseDetailVM.ContactMessage.Name,
                Email = courseDetailVM.ContactMessage.Email,
                Subject = courseDetailVM.ContactMessage.Subject,
                Message = courseDetailVM.ContactMessage.Message
            };
            _context.ContactMessages.Add(contactMessage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Detail));
        }
    }
}
