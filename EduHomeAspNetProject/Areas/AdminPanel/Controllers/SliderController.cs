﻿using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {
        private AppDbContext _context { get; }
        private IHostingEnvironment _env { get; }
        public SliderController(AppDbContext context,IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_context.Sliders);
        }

        public IActionResult Create()
        {
            if (_context.Sliders.Count() >= 4)
            {
                return Content("Şəkil sayı 4-dən artıq ola bilməz");
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<IActionResult> CreateSlider(Slider slides)
        {
            Slider slide = slides;
            if (slides.Photo == null)
                return View();
            foreach (IFormFile photo in slides.Photos)
            {
                if (photo == null)
                {
                    ModelState.AddModelError("Photos", "Zəhmət olmasa şəkil daxil edin");
                    return View();
                }
                if (!photo.ContentType.Contains("image/"))
                {
                    ModelState.AddModelError("Photos", "Yüklədiyiniz fayl şəkil tipində olmalıdır");
                    return View();
                }
                if (photo.Length / 1024 > 200)
                {
                    ModelState.AddModelError("Photos", "Şəkil ölçüsü 200kb-dan böyük ola bilməz");
                    return View();
                }
                string fileName = Guid.NewGuid().ToString() + photo.FileName;
                string path = Path.Combine(_env.WebRootPath, "img", fileName);
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    await photo.CopyToAsync(fileStream);
                }
                Slider slider = new Slider();
                slider.Image = fileName;
                await _context.Sliders.AddAsync(slider);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
