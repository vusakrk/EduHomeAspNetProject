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
    public class EventController : Controller
    {
        private AppDbContext _context { get; }
        public EventController(AppDbContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            EventVM eventVM = new EventVM
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                Event = _context.Events.OrderByDescending(p => p.Id).Take(4).ToList(),
                Speakers = _context.Speakers.ToList(),
                Blogs = _context.Blogs.OrderByDescending(p=>p.Id).Take(3).ToList()
            };
            return View(eventVM);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Event _event = await _context.Events.FindAsync(id);
            if (_event == null)
                return NotFound();
            List<EventSpeaker> eventSpeakers = _context.EventSpeakers.Where(p => p.EventId == id).ToList();
            List<Speaker> speakers = new List<Speaker>();
            foreach (EventSpeaker eventSpeaker in eventSpeakers)
            {
                speakers.Add(_context.Speakers.FirstOrDefault(p => p.Id == eventSpeaker.SpeakerId));

            }
            EventDetailVM detailVM = new EventDetailVM
            {
                BgImage = _context.BgImages.FirstOrDefault(),
                Blogs = _context.Blogs.OrderByDescending(p=>p.Id).Take(5).ToList(),
                Courses = _context.Courses.ToList(),
                Event = _event,
                Speakers = speakers
            };
            return View(detailVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detail(EventDetailVM eventDetailVM)
        {
            ContactMessage contactMessage = new ContactMessage
            {
                Name = eventDetailVM.ContactMessage.Name,
                Email = eventDetailVM.ContactMessage.Email,
                Subject = eventDetailVM.ContactMessage.Subject,
                Message = eventDetailVM.ContactMessage.Message,
            };
            _context.ContactMessages.Add(contactMessage);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Detail));
        }
    }
}
