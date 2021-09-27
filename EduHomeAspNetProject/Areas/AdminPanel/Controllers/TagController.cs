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
    public class TagController : Controller
    {
        private AppDbContext _context { get; }
        public TagController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Tag> tags = _context.Tags.ToList();
            return View(tags);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Tag tag)
        {

            if (ModelState.IsValid)
            {

                _context.Tags.Add(tag);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View();

        }
        public ActionResult Update(int id)
        {
            Tag tag = _context.Tags.Find(id);

            if (tag == null)
            {
                return NotFound();
            }

            return View(tag);
        }
        [HttpPost]
        public ActionResult Update(Tag tag)
        {

            if (ModelState.IsValid)
            {

                _context.Entry(tag).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(tag);

        }

        public ActionResult Delete(int id)
        {
            Tag tag = _context.Tags.Find(id);

            if (tag == null)
            {
                return NotFound();
            }

            _context.Tags.Remove(tag);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
