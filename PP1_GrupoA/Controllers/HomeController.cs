using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PP1_GrupoA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Aplicación con mvc framework 4.X, que inicie una aplicación web.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Aplicación para Práctica Programada 1";
            
            return View();
        }
    }
}