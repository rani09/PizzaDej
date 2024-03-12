using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaDej.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }

        public int IngredientTypeId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual IngredientType IngredientType { get; set; }
    }
}