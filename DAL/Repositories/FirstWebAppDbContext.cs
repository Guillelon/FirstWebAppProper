using DAL.Moldels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class FirstWebAppDbContext: DbContext
    {
        public DbSet<Car> Car { get; set; }
        public DbSet<Bike> Bike { get; set; }
        public DbSet<Branch> Branch{ get; set; }
        public DbSet<Client> Client { get; set; }

    }
}
