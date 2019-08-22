using DAL.Moldels;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class ClientController : Controller
    {
        private ClientRepository clientRepo;

        public ClientController()
        {
            clientRepo = new ClientRepository();
        }

       
        //public string Temp()
        //{
        //    return "pakistan";
        //}

        public ActionResult Create()
        {
            var client = new Client();
            return View(client);
        }

        [HttpPost]
        public ActionResult CreatePost(Client model)
        {

            clientRepo.Create(model);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int clientId) // index view must return BranchId 
        {
            var client = new Client();
            client = clientRepo.GetById(clientId);
            return View(client);
        }

        [HttpPost]
        public ActionResult EditPost(Client model)
        {
            if (model.Id <= 0) { }
            else
                clientRepo.Edit(model);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int clientId)
        {

            var client = new Client();
            client = clientRepo.GetById(clientId);

            return View(client);
        }

        [HttpPost]
        public ActionResult DeletePost(Client model)
        {

            clientRepo.Delete(model);

            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            var client = clientRepo.Get();
            return View(client);
        }
    }
}