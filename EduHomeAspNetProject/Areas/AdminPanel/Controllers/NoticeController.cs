using EduHomeAspNetProject.DAL;
using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.Areas.AdminPanel.Controllers
{[Area("AdminPanel")]
    public class NoticeController : Controller
    {
        private AppDbContext _context;
        public NoticeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<NoticeBoard> noticeBoards = _context.NoticeBoards.ToList();
            return View(noticeBoards);
        }
        public IActionResult CreateNotice()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateNotice(NoticeBoard noticeBoard)
        {
            if (!ModelState.IsValid) return NotFound();
            NoticeBoard notice = new NoticeBoard
            {
                Description = noticeBoard.Description,
                Date = noticeBoard.Date,
                AuthorBy = noticeBoard.AuthorBy
            };
            _context.NoticeBoards.Add(notice);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Update(int id)
        {
            NoticeBoard noticeBoard = _context.NoticeBoards.Find(id);

            if (noticeBoard == null)
            {
                return NotFound();
            }

            return View(noticeBoard);
        }
        [HttpPost]
        public ActionResult Update(NoticeBoard noticeBoard)
        {

            if (ModelState.IsValid)
            {

                _context.Entry(noticeBoard).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(noticeBoard);

        }

        public ActionResult Delete(int id)
        {
            NoticeBoard noticeBoard = _context.NoticeBoards.Find(id);

            if (noticeBoard == null)
            {
                return NotFound();
            }

            _context.NoticeBoards.Remove(noticeBoard);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
