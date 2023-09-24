using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dentist.Data
{
    public class DentistDbContext : IdentityDbContext
    {
        public DentistDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
