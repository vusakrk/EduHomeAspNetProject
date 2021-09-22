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
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<NoticeVideo> NoticeVideos { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Subscribe> Subscribers { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<TeacherAbout> TeacherAbouts { get; set; }
        public DbSet<TeacherHobby> TeacherHobbies { get; set; }
        public DbSet<TeacherSkill> TeacherSkills { get; set; }
        public DbSet<TeacherState> TeacherStates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Teacher>()
            //    .HasOne(t => t.TeacherInfo)
            //    .WithOne(t => t.Teacher)
            //    .HasForeignKey<TeacherInfo>(TeacherDetail => TeacherDetail.TeacherId);

            //modelBuilder.Entity<Teacher>()
            //    .HasOne(t => t.TeacherSkill)
            //    .WithOne(t => t.Teacher)
            //    .HasForeignKey<TeacherSkill>(s => s.Id);

            //modelBuilder.Entity<Course>()
            //    .HasOne(c => c.CourseDetail)
            //    .WithOne(c => c.Course)
            //    .HasForeignKey<CourseDetail>(c => c.Id);
            //modelBuilder.Entity<Course>()
            //    .HasOne(e => e.CourseFeature)
            //    .WithOne(e => e.Course)
            //    .HasForeignKey<CourseFeature>(e => e.Id);
        }
    }
}
