using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
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

        public IActionResult Index(int page = 1)
        {
            BlogVM blogVM = new BlogVM
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                Blogs = _context.Blogs.OrderByDescending(p => p.Id).Take(3).ToList(),
                Events = _context.Events.OrderByDescending(p => p.Id).Take(3).ToList(),
                BlogComments = _context.BlogComments.ToList(),
                
            };

            BlogVM blog = new BlogVM();
            blog.CurrentPage = page;
            blog.PageCount = Convert.ToInt32(Math.Ceiling(_context.Blogs.Count() / 4.0));
            blog.Blogs = _context.Blogs.OrderByDescending(p => p.Id).Skip((page - 1) * 4).Take(4).ToList();


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
                    Blog = blog,
                    BlogComments = _context.BlogComments.ToList(),
                    BlogCategories = _context.BlogCategories.ToList()
                };

                return View(detailVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Detail(BlogCommentVM blogCommentVM,int id)
        {
            BlogComment blogComment = new BlogComment();
            blogComment.Message = blogCommentVM.Message;
            blogComment.BlogId = id;
            _context.BlogComments.Add(blogComment);
            _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
            

        }
    }

