using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        //public ActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public ActionResult MobileBrands()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MobileBrands(FormCollection collection)
        {
            var brandName = collection["txtBrandName"];
            return View();
        }

        [HttpGet]
        public ActionResult MobileModels()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult MobileModels(MobileModelInfo model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult CustomerDetails()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CustomerDetails(CustomerDetailsInfo model)
        {
            return View();
        }

        [HttpGet]
        public ActionResult PurchaseParty()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PurchaseParty(CustomerDetailsInfo model)
        {
            return View();
        }
    }
}