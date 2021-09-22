using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Controllers
{
    public class TeacherController : Controller
    {
        private AppDbContext _context;
        public TeacherController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            TeacherVM teacherVM = new TeacherVM
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                Teachers = _context.Teachers.ToList(),
                TeacherAbouts = _context.TeacherAbouts.ToList(),
                TeacherSkills = _context.TeacherSkills.ToList(),
                TeacherHobbies = _context.TeacherHobbies.ToList(),
                Hobbies = _context.Hobbies.ToList()
            };
            return View(teacherVM);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Teacher teacher = await _context.Teachers.FindAsync(id);
            if (teacher == null)
                return NotFound();
            List<TeacherHobby> teacherHobbies = _context.TeacherHobbies.Where(p => p.TeacherId == id).ToList();
            List<Hobby> hobbies = new List<Hobby>();
            foreach (TeacherHobby teacherHobby in teacherHobbies)
            {
                hobbies.Add(_context.Hobbies.FirstOrDefault(p => p.Id == teacherHobby.HobbyId));
            }
            TeacherDetailVM detailVM = new TeacherDetailVM
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                Teacher = teacher,
                TeacherAbout = _context.TeacherAbouts.FirstOrDefault(p=>p.Id==teacher.TeacherAboutId),
                TeacherState = _context.TeacherStates.FirstOrDefault(p=>p.Id==teacher.TeacherStateId),
                Hobbies = hobbies,
                TeacherSkill = _context.TeacherSkills.FirstOrDefault(p => p.Id == teacher.TeacherSkillId)
            };
            return View(detailVM);
        }
    }
}
