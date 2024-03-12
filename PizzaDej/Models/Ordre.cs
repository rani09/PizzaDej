using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaDej.Models
{
    public class Ordre
    {
        public int OrdreId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int Zipcode { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public int Phone { get; set; }

        public DateTime DateNow { get; set; }

        public string CrustName { get; set; }

        public string IngredientDescription { get; set; }

        public decimal TotalPrice { get; set; }
    }
}