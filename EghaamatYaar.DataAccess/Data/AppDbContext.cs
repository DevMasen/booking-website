using EghaamatYaar.Models.Other;
using EghaamatYaar.Models.Place;
using EghaamatYaar.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace EghaamatYaar.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<HomeStay> homeStays { get; set; }
        public DbSet<OffCode> offCodes { get; set; }

        public DbSet<Owner> owner { get; set; }

    }
}
