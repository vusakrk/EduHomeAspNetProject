using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private AppDbContext _context { get; }
        public HeaderViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult>InvokeAsync()
        {
            Setting setting = _context.Settings.FirstOrDefault();
            return View(await Task.FromResult(setting));
        }
    }
}
