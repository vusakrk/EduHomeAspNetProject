using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.ViewComponents
{
    public class CoursesViewComponent:ViewComponent
    {
        private AppDbContext _context { get; }
        public CoursesViewComponent(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult>InvokeAsync(int count)
        {
            var course = _context.Courses.Select(course=>new Course
            {
                Id=course.Id,
                Name=course.Name,
                Description=course.Description,
                Image=course.Image
            }).OrderByDescending(course=>course.Id).Take(count);
            return View(await Task.FromResult(course));
        }
    }
}
