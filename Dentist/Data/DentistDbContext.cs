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

            base.OnModelCreating(modelBuilder);
        }
    }
}
