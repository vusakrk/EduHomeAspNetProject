using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Controllers
{
    public class ContactController : Controller
    {
        private AppDbContext _context { get; }
        public ContactController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ContactVM contactVM = new ContactVM
            {
                Setting = _context.Settings.FirstOrDefault(),
                BgImage = _context.BgImages.FirstOrDefault()
            };
            return View(contactVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(ContactVM contactVM)
        {
            contactVM.Setting = _context.Settings.FirstOrDefault();
            contactVM.BgImage = _context.BgImages.FirstOrDefault();
            if (!ModelState.IsValid)
            {
                return View(contactVM);
            }
            ContactMessage contactMessage = new ContactMessage
            {
                Name = contactVM.ContactMessage.Name,
                Email = contactVM.ContactMessage.Email,
                Subject = contactVM.ContactMessage.Subject,
                Message = contactVM.ContactMessage.Message
            };
            
            _context.ContactMessages.Add(contactMessage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
    }
}
