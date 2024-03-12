using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PizzaDej.Models
{
    public class IngredientRelation
    {
        [Key, Column(Order = 0)]
        public int IngredientId { get; set; }
        [Key, Column(Order = 1)]
        public int CrustId { get; set; }

        public int Amount { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        public virtual Crust Crust { get; set; }
    }
}