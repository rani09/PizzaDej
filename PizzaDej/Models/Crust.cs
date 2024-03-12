using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaDej.Models
{
    public class Crust
    {
        public int CrustId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal IngredientCalculation { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }
    }
}