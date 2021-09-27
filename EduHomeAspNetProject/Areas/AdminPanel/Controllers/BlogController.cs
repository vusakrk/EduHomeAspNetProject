using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class BlogController : Controller
    {
        private AppDbContext _context { get; }
        public IWebHostEnvironment _env { get; }
        private UserManager<AppUser> _userManager { get; }
        public BlogController(AppDbContext context,IWebHostEnvironment env,UserManager<AppUser> userManager)
        {
            _context = context;
            _env = env;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.ToList();
            return View(blogs);
        }
        public ActionResult Create()
        {
            ViewBag.Categories = _context.BlogCategories.ToList();
            return View();
        }
        public ActionResult Update(int? id)
        {
            Blog blog = _context.Blogs.Find(id);

            if (blog == null)
            {
                return NotFound();
            }

            ViewBag.Categories = _context.BlogCategories.ToList();
            return View(blog);

        }
        public IActionResult Delete(int? id)
        {
            var blog = _context.Blogs.FirstOrDefault(sl => sl.Id == id);
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
