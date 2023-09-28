using Dentist.Services;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dentist.Data
{
    public class DentistDbContext :IdentityDbContext<AppUser>
    {
        public DentistDbContext(DbContextOptions<DentistDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ShopingCart>().HasKey(s => new { s.AppUserId, s.bookId });
            //modelBuilder.Entity<OrderDetail>().HasKey(o => new { o.orderId, o.bookId });
            //modelBuilder.Entity<Schedule>()
            // .HasOne(s => s.Doctor)
            // .WithMany(u => u.Schedules)
            // .HasForeignKey(s => s.DocotrId);
            
            //// Filter the Schedule entities based on the user's role
            //modelBuilder.Entity<Schedule>()
            //    .HasQueryFilter(s => s.Doctor == "patient"); // Only allow "patient" role
        

            base.OnModelCreating(modelBuilder);
        }
    }
}
