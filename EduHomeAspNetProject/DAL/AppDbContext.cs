using EduHomeAspNetProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherDegree> TeacherDegrees { get; set; }
        public DbSet<TeacherFaculty> TeacherFaculties { get; set; }
        public DbSet<TeacherHobbie> TeacherHobbies { get; set; }
        public DbSet<TeacherInfo> TeacherInfos { get; set; }
        public DbSet<TeacherSkill> TeacherSkills { get; set; }
        public DbSet<Hobbie> Hobbies { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.TeacherInfo)
                .WithOne(t => t.Teacher)
                .HasForeignKey<TeacherInfo>(TeacherDetail => TeacherDetail.TeacherId);

            modelBuilder.Entity<Teacher>()
                .HasOne(t => t.TeacherSkill)
                .WithOne(t => t.Teacher)
                .HasForeignKey<TeacherSkill>(s => s.Id);
        }
    }
}
