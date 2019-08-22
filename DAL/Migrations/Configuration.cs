namespace DAL.Migrations
{
    using DAL.Moldels;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Repositories.FirstWebAppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Repositories.FirstWebAppDbContext context)
        {
            //if (context.Branch.Count() == 0)
            //{
            //    var branch = new Branch();
            //    branch.Name = "Scaranton";
            //    branch.Manager = "Stanley";
            //    context.Branch.Add(branch);
            //    context.SaveChanges();
            //}

            //if(context.Car.Count()==0)
            //{
            //    var branch = context.Branch.Where(b => b.Name == "Scaranton").First();
            //    var car = new Car();
            //    car.BranchId = branch.Id;
            //    car.Brand = "chevy";
            //    car.Color = "red";
            //    context.Car.Add(car);
            //    context.SaveChanges();

            //}
        }
    }
}
