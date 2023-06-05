using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = ALPER_BARLAS;DataBase = RentACarProjectDb;Trusted_Connection=true");
        }

        public DbSet<Customer> customers { get; set; }

        public DbSet<Car> cars { get; set; }

        public DbSet<Brand> brands { get; set; }

        public DbSet<Rental> rentals { get; set;}

        public DbSet<Color> colors { get; set; }

        public DbSet<User> users { get; set; }
    }
}
