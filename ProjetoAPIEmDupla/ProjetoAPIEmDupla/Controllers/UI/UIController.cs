using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoAPIEmDupla.Controllers.UI
{
    public class UIController : Controller
    {
        // GET: UI
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OS(int id)
        {
            return View();
        }
    }
}