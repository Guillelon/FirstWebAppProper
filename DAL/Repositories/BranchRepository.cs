using DAL.Moldels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BranchRepository
    {
        private FirstWebAppDbContext context;

        public BranchRepository()
        {
            context = new FirstWebAppDbContext();
        }


        public List<Branch> Get() 
        {
            return context.Branch.ToList(); 

        }

        public Branch GetById(int id)
        {

            var branch = context.Branch.Where(b => b.Id == id).FirstOrDefault();
            return branch;

        }

        public Branch Create(Branch branch)
        {

            context.Branch.Add(branch);
            context.SaveChanges();
            return branch;
        }

        public Branch Edit(Branch branch)
        {
            context.Entry(branch).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return branch;
        }

        public void Delete(Branch branch)
        {
            var branchToDelete = GetById(branch.Id);
            context.Entry(branchToDelete).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

    }
}
