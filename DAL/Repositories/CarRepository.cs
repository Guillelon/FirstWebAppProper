using DAL.Moldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CarRepository
    {
        private FirstWebAppDbContext context;

        public CarRepository()
        {
            context = new FirstWebAppDbContext();
        }

        public Car GetById(int id)
        {

            var car = context.Car.Where(b => b.Id == id).FirstOrDefault();
            return car;

        }
        public List<Car> Get()
        {
          
            return context.Car.ToList();

        }

        public List<Car> GetByColor(string color)
        {
            var cars = context.Car.Where(b => b.Color == color).ToList();
            return cars;
        }

        public List<Car> GetByBranchId(int BranchId)
        {
            var cars = context.Car.Where(b => b.BranchId == BranchId).ToList();
            return cars;
        }

        public Car Create(Car car)
        {
           
            context.Car.Add(car);
            context.SaveChanges();
            return car;
        }

        public Car Edit(Car car)
        {
            context.Entry(car).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return car;
        }

        public void Delete(Car car)
        {
            var carToDelete = GetById(car.Id);
            context.Entry(carToDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }



    }


}
