using PizzaDej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PizzaDej.ViewModels;

namespace PizzaDej.Controllers
{
    public class AdminController : Controller
    {
        private Model1 db = new Model1();

        #region Ingredient Type

        [Route("admin/Ingredient-Types")]
        public ActionResult IngredientType_Index()
        {
            return View("IngredientType_Index", db.IngredientTypes.Select(i => new VM_IngredientType_List { IngredientTypeId = i.IngredientTypeId, Name = i.Name, DateCreated = i.DateCreated }).ToList());
        }

        [Route("admin/IngredientType_Create")]
        public ActionResult IngredientType_Create()
        {
            return View();
        }
        [Route("admin/IngredientType_Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IngredientType_Create(VM_IngredientType_Create ingredientType)
        {
            if (ModelState.IsValid)
            {
                IngredientType model = new IngredientType();
                model.Name = ingredientType.Name;
                model.DateCreated = DateTime.Now;

                db.IngredientTypes.Add(model);
                db.SaveChanges();
                return RedirectToAction("IngredientType_Index");
            }

            return View(ingredientType);
        }
        [Route("admin/IngredientType_Edit")]

        public ActionResult IngredientType_Edit(int? id)
        {

            if (id.HasValue)
            {
                IngredientType model = db.IngredientTypes.Find(id);
                if (model != null)
                {
                    VM_IngredientType_Edit viewModel = new VM_IngredientType_Edit();
                    viewModel.IngredientTypeId = model.IngredientTypeId;
                    viewModel.Name = model.Name;

                    return View(viewModel);
                }
            }
            return RedirectToAction("Index");
        }

        [Route("admin/IngredientType_Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IngredientType_Edit(VM_IngredientType_Edit viewModel)
        {
            if (ModelState.IsValid)
            {
                IngredientType model = db.IngredientTypes.Find(viewModel.IngredientTypeId);

                if (model != null)
                {
                    model.Name = viewModel.Name;
                    db.SaveChanges();
                    return RedirectToAction("IngredientType_Index");
                }
                else
                {
                    ModelState.AddModelError("", "Vil du dø");
                }
            }
            return View(viewModel);
        }

        [Route("admin/IngredientType_Delete")]
        public ActionResult IngredientType_Delete(int id)
        {
            IngredientType ingredientType = db.IngredientTypes.Find(id);
            db.IngredientTypes.Remove(ingredientType);
            db.SaveChanges();

            return RedirectToAction("IngredientType_Index");
        }
        #endregion

        #region Crusts

        [Route("admin/Crusts")]
        public ActionResult Crust_Index()
        {
            return View("Crust_Index", db.Crusts.Select(i => new VM_Crust_List { CrustId = i.CrustId, Price = i.Price, Name = i.Name, IngredientCalculation = i.IngredientCalculation, DateCreated = i.DateCreated }).ToList());
        }

        [Route("admin/Crust_Create")]
        public ActionResult Crust_Create()
        {
            return View();
        }
        [Route("admin/Crust_Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crust_Create(VM_Crust_Create viewModel)
        {
            if (ModelState.IsValid)
            {
                Crust model = new Crust();
                model.Name = viewModel.Name;
                model.Price = viewModel.Price;
                model.IngredientCalculation = viewModel.IngredientCalculation;
                model.DateCreated = DateTime.Now;

                db.Crusts.Add(model);
                db.SaveChanges();
                return RedirectToAction("Crust_Index");
            }

            return View(viewModel);
        }

        [Route("admin/Crust_Edit")]
        public ActionResult Crust_Edit(int? id)
        {

            if (id.HasValue)
            {
                Crust model = db.Crusts.Find(id);
                if (model != null)
                {
                    VM_Crust_Edit viewModel = new VM_Crust_Edit();
                    viewModel.CrustId = model.CrustId;
                    viewModel.Name = model.Name;
                    viewModel.Price = model.Price;
                    return View(viewModel);
                }
            }
            return RedirectToAction("Index");
        }

        [Route("admin/Crust_Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crust_Edit(VM_Crust_Edit viewModel)
        {
            if (ModelState.IsValid)
            {
                Crust model = db.Crusts.Find(viewModel.CrustId);

                if (model != null)
                {
                    model.Name = viewModel.Name;
                    model.Price = viewModel.Price;
                    db.SaveChanges();

                    return RedirectToAction("Crust_Index");
                }
                else
                {
                    ModelState.AddModelError("", "Vil du dø");
                }
            }
            return View(viewModel);
        }

        [Route("admin/Crust_Delete")]
        public ActionResult Crust_Delete(int id)
        {
            Crust crust = db.Crusts.Find(id);
            db.Crusts.Remove(crust);
            db.SaveChanges();
            return RedirectToAction("Crust_Index");
        }
        #endregion

        #region Ingredienser

        [Route("admin/Ingredient-Index")]
        public ActionResult Ingredient_Index()
        {
            return View("Ingredient_Index", db.Ingredients.Select(i => new VM_Ingredient_List { Name = i.Name, IngredientId = i.IngredientId, DateCreated = i.DateCreated, IngredientType = i.IngredientType.Name, IngredientTypeId = i.IngredientTypeId, Price = i.Price }).ToList());
        }

        [Route("admin/Ingredient_Create")]
        public ActionResult Ingredient_Create()
        {
            ViewBag.IngredientTypeId = new SelectList(db.IngredientTypes, "IngredientTypeId", "Name");
            return View();
        }

        [Route("admin/Ingredient_Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ingredient_Create(VM_Ingredient_Create ingredient)
        {
            if (ModelState.IsValid)
            {
                Ingredient model = new Ingredient();
                model.Name = ingredient.Name;
                model.IngredientTypeId = ingredient.IngredientTypeId;
                model.Price = ingredient.Price;
                model.DateCreated = DateTime.Now;

                db.Ingredients.Add(model);
                db.SaveChanges();
                return RedirectToAction("Ingredient_Index");
            }
            ViewBag.IngredientTypeId = new SelectList(db.IngredientTypes, "IngredientTypeId", "Name");
            return View(ingredient);
        }

        public ActionResult Ingredient_Edit(int? id)
        {
            if (id.HasValue)
            {
                Ingredient model = db.Ingredients.Find(id);
                if (model != null)
                {
                    VM_Ingredient_Edit viewModel = new VM_Ingredient_Edit();
                    viewModel.IngredientId = model.IngredientId;
                    viewModel.Name = model.Name;
                    viewModel.Price = model.Price;
                    viewModel.IngredientTypeId = model.IngredientTypeId;
                    return View(viewModel);
                }
            }
            return RedirectToAction("Index");
        }

        [Route("admin/Ingredient_Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ingredient_Edit(VM_Ingredient_Edit viewModel)
        {
            if (ModelState.IsValid)
            {
                Ingredient model = db.Ingredients.Find(viewModel.IngredientId);

                if (model != null)
                {
                    model.Name = viewModel.Name;
                    model.Price = viewModel.Price;
                    db.SaveChanges();
                    return RedirectToAction("Ingredient_Index");
                }
                else
                {
                    ModelState.AddModelError("", "Vil du dø");
                }
            }
            return View(viewModel);
        }

        #endregion

        #region Ordres

        [Route("admin/Ordre-index")]
        public ActionResult Ordre_Index()
        {
            return View("Ordre_Index", db.Ordres.Select(i => new VM_Ordre_List { Name = i.Name, Address = i.Address, City = i.City, IngredientDescription = i.IngredientDescription, OrdreId = i.OrdreId, Phone = i.Phone, TotalPrice = i.TotalPrice, Zipcode = i.Zipcode, Email = i.Email, CrustName = i.CrustName, DateNow = i.DateNow }).ToList());
        }

        [Route("admin/Ordre_Edit")]
        public ActionResult Ordre_Edit(int? id)
        {
            if (id.HasValue)
            {
                Ordre model = db.Ordres.Find(id);

                if (model != null)
                {
                    VM_Ordre_Edit viewModel = new VM_Ordre_Edit();
                    viewModel.OrdreId = model.OrdreId;
                    viewModel.Name = model.Name;
                    viewModel.Phone = model.Phone;
                    viewModel.City = model.City;
                    viewModel.Address = model.Address;
                    viewModel.CrustName = model.CrustName;
                    viewModel.IngredientDescription = model.IngredientDescription;
                    viewModel.TotalPrice = model.TotalPrice;
                    viewModel.Zipcode = model.Zipcode;
                    viewModel.Emai = model.Email;
                    viewModel.DateNow = model.DateNow;
                    return View(viewModel);
                }
            }
            return RedirectToAction("Index");
        }

        [Route("admin/Ordre_Edit")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ordre_Edit(VM_Ordre_Edit viewModel)
        {
            if (ModelState.IsValid)
            {
                Ordre model = db.Ordres.Find(viewModel.OrdreId);

                if (model != null)
                {
                    model.OrdreId = viewModel.OrdreId;
                    model.Name = viewModel.Name;
                    model.Phone = viewModel.Phone;
                    model.City = viewModel.City;
                    model.Address = viewModel.Address;
                    model.CrustName = viewModel.CrustName;
                    model.IngredientDescription = viewModel.IngredientDescription;
                    model.TotalPrice = viewModel.TotalPrice;
                    model.Zipcode = viewModel.Zipcode;
                    model.Email = viewModel.Emai;
                    model.DateNow = viewModel.DateNow;
                    db.SaveChanges();
                    return RedirectToAction("Ordre_Index");
                }
                else
                {
                    ModelState.AddModelError("", "Vil du dø");
                }
            }
            return View(viewModel);
        }

        [Route("admin/Ordre_Delete")]
        public ActionResult Ordre_Delete(int id)
        {
            Ordre ordre = db.Ordres.Find(id);
            db.Ordres.Remove(ordre);
            db.SaveChanges();

            return RedirectToAction("Ordre_Index");
        }

        #endregion

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