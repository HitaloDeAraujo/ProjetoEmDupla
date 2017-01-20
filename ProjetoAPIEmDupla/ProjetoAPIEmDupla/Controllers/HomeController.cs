using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoAPIEmDupla.Models;

namespace ProjetoAPIEmDupla.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Pages";

            return View();
        }

        private bdDuplaEntities bd = new bdDuplaEntities();

        public ActionResult getCliente()
        {
            List<Cliente> Lista =  bd.Cliente.ToList();

            return View(Lista);
        }

        public IEnumerable<Cliente> Teste()
        {
            IEnumerable<Cliente> Lista = bd.Cliente.ToList();

            return Lista;
        }

        
        public ActionResult Create()
        {
            ViewBag.Title = "Adicionar Cliente";

            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            if(ModelState.IsValid)
            {
                bd.Cliente.Add(cliente);
                bd.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
