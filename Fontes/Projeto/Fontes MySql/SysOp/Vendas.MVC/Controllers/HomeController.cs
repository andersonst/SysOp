using SisOpe.Application;
using SisOpe.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vendas.MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IUnitOfWorkAppService _uoW;

        public HomeController(IUnitOfWorkAppService uoW)
        {
            _uoW = uoW;
        }

        public ActionResult Index()
        {
            var lista = _uoW.PessoaApp.GetAll().ToList();
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

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
