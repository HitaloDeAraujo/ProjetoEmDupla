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

        
    }
}
