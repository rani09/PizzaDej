using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaDej.ViewModels
{
    public class VM_Ordre_List
    {
        public int OrdreId { get; set; }

        [Display(Name = "Navn")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Postnummer")]
        [Required]
        public int Zipcode { get; set; }

        [Display(Name = "By")]
        [Required]
        public string City { get; set; }

        [Display(Name = "E-mail")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        [Required]
        public int Phone { get; set; }

        public DateTime DateNow { get; set; }

        public string  CrustName { get; set; }

        public string IngredientDescription { get; set; }

        public decimal TotalPrice { get; set; }
    }
  
    public class VM_Ordre_Edit
    {
        public int OrdreId { get; set; }

        [Display(Name = "Navn")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }

        [Display(Name = "Postnummer")]
        [Required]
        public int Zipcode { get; set; }

        [Display(Name = "By")]
        [Required]
        public string City { get; set; }

        [Display(Name = "E-mail")]
        [Required]
        public string Emai { get; set; }

        [Display(Name = "Telefon")]
        [Required]
        public int Phone { get; set; }

        public DateTime DateNow { get; set; }

        public string CrustName { get; set; }

        public string IngredientDescription { get; set; }

        public decimal TotalPrice { get; set; }
    }
}