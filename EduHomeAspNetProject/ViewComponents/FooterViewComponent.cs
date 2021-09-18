using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {
        private AppDbContext _context { get; }
        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            FooterVM footerVM = new FooterVM
            {
                Setting = _context.Settings.FirstOrDefault()
            };
            return View(await Task.FromResult(footerVM));
        }
    }
}
