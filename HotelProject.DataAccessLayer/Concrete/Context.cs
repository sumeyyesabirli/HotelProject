using HotelProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =SUM; initial catalog = HotelProjectGroup; integrated security = true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<BookRoom> BookRooms { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HotelResume> HotelResumes { get; set; }
        public DbSet<RoomDetail> RoomDetails { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Privileges> Privilegeses { get; set; }

       
    }
}
