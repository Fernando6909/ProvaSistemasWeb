using ProvaCliente.Context;
using ProvaCliente.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProvaCliente.Controllers
{
    public class ProvaController : Controller
    {
        private Contexto db = new Contexto();
        // GET: Cliente
        public ActionResult Index()
        {
            return View(db.Cliente.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                db.Cliente.Add(clienteModel);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(clienteModel);
        }


        [HttpGet]
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ClienteModel clienteModel = db.Cliente.Find(Id);

            if (clienteModel == null)
            {
                return HttpNotFound();
            }

            return View(clienteModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ClienteModel clienteModel)
        {
            db.Entry(clienteModel).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}