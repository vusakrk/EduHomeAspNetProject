using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeAspNetProject.DAL
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<HeaderContact> HeaderContacts { get; set; }
        public DbSet<BrandLogo> BrandLogo { get; set; }
        public DbSet<ServiceArea> ServiceAreas { get; set; }
        public DbSet<ViewCourse> ViewCourses { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<NoticeVideo> NoticeVideos { get; set; }
    }
}
