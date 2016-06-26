using Newtonsoft.Json.Linq;
using SisOpe.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisOpe.MVC.Controllers
{
    public class HomeController : Controller
    {

        private static UsuarioAppService _usuarioAppService;

        public HomeController(UsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

           var lista =  _usuarioAppService.GetAll().ToList();


            return View();

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
