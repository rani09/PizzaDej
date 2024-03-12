using PizzaDej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaDej.ViewModels
{
    public class VM_Pizza
    {
        public int CrustId { get; set; }
        public string CrustName { get; set; }
        public decimal TotalPrice { get; set; }
        public string IngredientDescription { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}