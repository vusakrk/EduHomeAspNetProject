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
    public class BlogCategoryController : Controller
    {
        private AppDbContext _context;
        public BlogCategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<BlogCategory> blogCategories = _context.BlogCategories.ToList();
            return View(blogCategories);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(BlogCategory blogCategory)
        {

            if (ModelState.IsValid)
            {

                _context.BlogCategories.Add(blogCategory);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult Update(int? id)
        {
            BlogCategory blogCategory = _context.BlogCategories.Find(id);

            if (blogCategory == null)
            {
                return NotFound();
            }
            return View(blogCategory);
        }
        [HttpPost]
        public ActionResult Update(BlogCategory blogCategory)
        {

            if (ModelState.IsValid)
            {

                _context.Entry(blogCategory).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(blogCategory);

        }
        public ActionResult Delete(int id)
        {
            BlogCategory blogCategory = _context.BlogCategories.Find(id);

            if (blogCategory == null)
            {
                return NotFound();
            }

            _context.BlogCategories.Remove(blogCategory);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
