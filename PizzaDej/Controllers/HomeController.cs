using PizzaDej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaDej.ViewModels;
namespace PizzaDej.Controllers
{
    public class HomeController : Controller
    {
        private Model1 db = new Model1();

        // GET: Home
        public ActionResult Index()
        {
            VM_View_Home_Index viewModel = new VM_View_Home_Index();
            viewModel.Crusts = db.Crusts.ToList();
            viewModel.Ingredients = db.Ingredients.ToList();

            return View(viewModel);
        }
        public ActionResult Kvitting()
        {
            return View(db.Ordres.ToList().OrderByDescending(a => a.DateNow).Take(1));
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}