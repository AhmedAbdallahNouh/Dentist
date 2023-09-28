using Dentist.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dentist.Data
{
    public class DentistDbContext :IdentityDbContext<AppUser>
    {

        public DentistDbContext(DbContextOptions<DentistDbContext> options) : base(options)
        {
        }

        //private T GetService<T>()
        //{
        //    using var scope = _serviceProvider.CreateScope();
        //    var service = scope.ServiceProvider.GetRequiredService<T>();
        //    return service;
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //using var scope = _serviceProvider.CreateScope();
            //var roleManager = GetService<RoleManager<IdentityRole>>();
            //var doctorRoleId = roleManager.FindByNameAsync("Doctor").Result.Id;

            //modelBuilder.Entity<ShopingCart>().HasKey(s => new { s.AppUserId, s.bookId });
            //modelBuilder.Entity<OrderDetail>().HasKey(o => new { o.orderId, o.bookId });
            modelBuilder.Entity<Schedule>()
             .HasOne(s => s.Doctor)
             .WithMany(u => u.Schedules)
             .HasForeignKey(s => s.DocotrId);

            // Filter the Schedule entities based on user roles
            modelBuilder.Entity<Schedule>()
                .HasQueryFilter(s =>
                    s.Doctor.UserRoles.Any(ur => ur.RoleId == "ab626ec5-33d7-4c4b-8523-80a0840c37ff")
                );


            // Define relationships between Appointment, Doctor (AppUser), and Patient (AppUser)
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Doctor)
                .WithMany(u => u.AppointmentsAsDoctor)
                .HasForeignKey(a => a.DocotrId)
                .OnDelete(DeleteBehavior.Restrict); // Optional, prevents cascade delete

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Patient)
                .WithMany(u => u.AppointmentsAsPatient)
                .HasForeignKey(a => a.patientId)
                .OnDelete(DeleteBehavior.Restrict); // Optional, prevents cascade delete
        

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
