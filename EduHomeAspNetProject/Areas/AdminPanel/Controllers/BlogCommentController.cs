using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class BlogCommentController : Controller
    {
        private AppDbContext _context { get; }
        public BlogCommentController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<BlogComment> blogComments = _context.BlogComments.Include("Blog").Include("AppUser").ToList();
            return View(blogComments);
        }
    }
}
