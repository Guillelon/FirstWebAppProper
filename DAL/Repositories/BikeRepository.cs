using DAL.Moldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BikeRepository
    {
        private FirstWebAppDbContext context;

        public BikeRepository()
        {
            context = new FirstWebAppDbContext();
        }

        public List<Bike> Get()
        {
            return context.Bike.ToList();

        }

        public Bike Create(Bike bike)
        {
         
            context.Bike.Add(bike);
            context.SaveChanges();
            return bike;
        }
    }
}
