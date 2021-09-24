using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Controllers
{
    public class SubscribeController : Controller
    {
        private AppDbContext _context;
        public SubscribeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Subscribe(FooterVM footerVM)
        {
            bool exists = _context.Subscribes.Any(s => s.Email == footerVM.Subscribe.Email);
            if (exists)
            {
                return Content("This email already exist");
            }
            Subscribe subscribe = new Subscribe
            {
                Email = footerVM.Subscribe.Email
            };
            _context.Subscribes.Add(subscribe);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index","Home");
        }
    }
}
