using EghaamatYaar.Models.Place;
using EghaamatYaar.Models.Users;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EghaamatYaar.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<HomeStay> HomeStayes { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
