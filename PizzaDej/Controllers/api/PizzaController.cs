using PizzaDej.Models;
using PizzaDej.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace PizzaDej.Controllers.api
{
    public class PizzaController : ApiController
    {
        private Model1 db = new Model1();

        [HttpGet]
        [ResponseType(typeof(VM_Pizza))]
        public IHttpActionResult Crusts(int id)
        {
            Crust crust = db.Crusts.Find(id);
            if (crust != null)
            {
                VM_Pizza viewModel = new VM_Pizza();
                viewModel.CrustId = id;
                viewModel.CrustName = crust.Name;
                viewModel.TotalPrice = crust.Price;

                return Ok(viewModel);
            }
            return NotFound();
        }


        [HttpGet]
        [ResponseType(typeof(VM_Pizza))]
        public IHttpActionResult Ingredients([FromUri]int?[] ingredient, int id)
        {
            Crust crust = db.Crusts.Find(id);
            if (crust != null)
            {
                VM_Pizza viewModel = new VM_Pizza();
                viewModel.CrustId = id;
                viewModel.CrustName = crust.Name;
                viewModel.TotalPrice = crust.Price;
                if (ingredient != null)
                {
                    foreach (int item in ingredient)
                    {
                        Ingredient ing = db.Ingredients.Find(item);
                        if (ing != null)
                        {
                            viewModel.IngredientDescription += ing.Name.ToLower() + ", ";
                            viewModel.TotalPrice += ing.Price;
                        }
                    }
                    viewModel.IngredientDescription = viewModel.IngredientDescription.Remove(viewModel.IngredientDescription.Length - 2);
                }
                return Ok(viewModel);
            }

            return NotFound();
        }

        [HttpPost]
        [ResponseType(typeof(Ordre))]
        public IHttpActionResult Order(Ordre order)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            order.DateNow = DateTime.Now;
            db.Ordres.Add(order);
            db.SaveChanges();

            return Ok(order);
        }

    }
}

