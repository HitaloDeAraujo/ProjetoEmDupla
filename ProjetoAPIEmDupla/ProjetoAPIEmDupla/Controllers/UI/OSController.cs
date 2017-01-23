using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ProjetoAPIEmDupla.Controllers
{
    public class OSController : Controller
    {
        // GET: OS
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OS()
        {
            return View();
        }
    }
}