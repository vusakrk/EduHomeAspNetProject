using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using EduHomeAspNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
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
                Event = _context.Events.Take(9).ToList(),
                Speakers = _context.Speakers.ToList(),
                EventCategories = _context.EventCategories.ToList(),
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
                Speakers = speakers,
                Tags = _context.Tags.ToList(),
                EventCategories = _context.EventCategories.ToList()
            };
            return View(detailVM);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Message(EventCommentVM eventCommentVM,int id)
        {
            
            EventComment eventComment = new EventComment();
            eventComment.Message = eventCommentVM.Message;
            eventComment.EventId = id;
            _context.EventComments.Add(eventComment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
