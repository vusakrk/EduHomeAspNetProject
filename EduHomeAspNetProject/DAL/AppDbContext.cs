using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.DAL
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<BgImage> BgImages { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<NoticeVideo> NoticeVideos { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}
