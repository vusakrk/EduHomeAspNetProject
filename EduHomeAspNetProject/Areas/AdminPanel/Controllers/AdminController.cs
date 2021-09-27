using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.AdminPanel
{
    [Area("AdminPanel")]
    public class AdminController : Controller
    {
        private AppDbContext _context { get; }
        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Admin> admins = _context.Admins.ToList();
            return View(admins);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Admin admin)
        {
            if (ModelState.IsValid)
            {
                Admin Admin = new Models.Admin();

                if (admin.Password != null)
                {
                    Admin.Password = (admin.Password);
                }

                Admin.Name = admin.Name;
                Admin.Surname = admin.Surname;
                Admin.Username = admin.Username;
                Admin.Email = admin.Email;

                _context.Admins.Add(Admin);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(admin);
        }

        public ActionResult Update(int id)
        {
            Admin admin = _context.Admins.Find(id);

            if (admin == null)
            {
                return NotFound();
            }
            return View(admin);
        }
        [HttpPost]
        public ActionResult Update(Models.Admin admin)
        {
            if (ModelState.IsValid)
            {
                Models.Admin Admin = _context.Admins.Find(admin.Id);


                Admin.Name = admin.Name;
                Admin.Surname = admin.Surname;
                Admin.Username = admin.Username;
                Admin.Email = admin.Email;



                _context.Entry(Admin).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(admin);
        }
        public ActionResult Delete(int id)
        {
            Models.Admin admin = _context.Admins.Find(id);

            if (admin == null)
            {
                return NotFound();
            }
            _context.Admins.Remove(admin);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
