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
    public class BlogController : Controller
    {
        private AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? page)
        {
            ViewBag.PageCount = Math.Ceiling((decimal)_context.Blogs.Count() / 4);
            BlogVM blogVM = new BlogVM
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                Blogs = _context.Blogs.OrderByDescending(p => p.Id).Take(4).ToList(),
                //Events = _context.Events.OrderByDescending(p => p.Id).Take(3).ToList()
            };
            ViewBag.Pagination = 1;
            if (page != null)
            {
                ViewBag.Pagination = page;
            }
            return View(blogVM);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Blog blog = await _context.Blogs.FindAsync(id);
            if (blog==null)
            
                return NotFound();
                BlogDetailVM detailVM = new BlogDetailVM
                {
                    BgImage = _context.BgImages.FirstOrDefault(),
                    Courses = _context.Courses.Take(4).ToList(),
                    Events = _context.Events.OrderByDescending(p=>p.Id).Take(3).ToList(),
                    Blog= blog
                };
                return View(detailVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detail(EventDetailVM detailVM)
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
            
        }
    }

