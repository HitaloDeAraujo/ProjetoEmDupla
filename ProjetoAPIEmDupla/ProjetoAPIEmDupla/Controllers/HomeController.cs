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

        public IEnumerable<Cliente> getCliente()
        {
            IEnumerable<Cliente> Lista = bd.Cliente.ToList();

            return Lista;
        }

        public IEnumerable<Cliente> Teste()
        {
            IEnumerable<Cliente> Lista = bd.Cliente.ToList();

            return Lista;
        }
    }
}
