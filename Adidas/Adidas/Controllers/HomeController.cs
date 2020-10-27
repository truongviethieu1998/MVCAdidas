using Adidas.Models.Enity;
using ShopSWE.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Adidas.Controllers
{
    public class HomeController : Controller
    {
        public adidasEntities db = new adidasEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Giay()
        {
            var Product = new ProductNew();
            ViewBag.ProductNew = Product.ListNewProduct();
            return View();
        }
        public ActionResult QuanAo()
        {
            var Product = new ProductNew();
            ViewBag.ProductNew = Product.QuanAo();
            return View();
        }
        public ActionResult Phukien()
        {
            var Product = new ProductNew();
            ViewBag.ProductNew = Product.Phukien();
            return View();
        }
    }
}