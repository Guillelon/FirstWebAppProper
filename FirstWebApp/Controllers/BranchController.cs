using DAL.Moldels;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class BranchController : Controller
    {
        private BranchRepository branchRepo;

        public BranchController()
        {
            branchRepo = new BranchRepository();
        }


        

        public ActionResult Create()
        {
            var branch = new Branch();           
            return View(branch);
        }

        [HttpPost]
        public ActionResult CreatePost(Branch model)
        {

            branchRepo.Create(model);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int BranchId) // index view must return BranchId 
        {
            var branch = new Branch();
            branch = branchRepo.GetById(BranchId); 
            return View(branch);
        }

        [HttpPost]
        public ActionResult EditPost(Branch model)
        {
            if (model.Id <= 0) { }
            else
                branchRepo.Edit(model);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int branchId)
        {

            var branch = new Branch();
            branch = branchRepo.GetById(branchId);

            return View(branch);
        }

        [HttpPost]
        public ActionResult DeletePost(Branch model)
        {

            branchRepo.Delete(model);

            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            var branch = branchRepo.Get();
            return View(branch);
        }
    }
}