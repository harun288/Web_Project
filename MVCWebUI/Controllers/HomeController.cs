using Business.Repository;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        BaseRepository<Product> _productRepository = new BaseRepository<Product>();
        public ActionResult Index()
        {
            var model = _productRepository.GetAll();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}