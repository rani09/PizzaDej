using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaDej.ViewModels
{
    public class VM_Crust_List
    {
        public int CrustId { get; set; }

        [Required, MinLength(2, ErrorMessage = "Min 2 tegn"), MaxLength(20, ErrorMessage = "Max 20 tegn")]
        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Required, Range(0, 100, ErrorMessage = "mellem 0-100 kr.")]
        [Display(Name = "Pris")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Regne formular")]
        public decimal IngredientCalculation { get; set; }


        [Display(Name = "Oprette den")]
        public DateTime DateCreated { get; set; }

    }

    public class VM_Crust_Create
    {
        [Required(ErrorMessage = "Skal Udfyldes"), MinLength(2, ErrorMessage = "Min 2 tegn"), MaxLength(20, ErrorMessage = "Max 20 tegn")]
        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal IngredientCalculation { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

    }

    public class VM_Crust_Edit
    {
        public int CrustId { get; set; }

        [Required, MinLength(2, ErrorMessage = "Min 2 tegn"), MaxLength(20, ErrorMessage = "Max 20 tegn")]
        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Required, Range(0, 100, ErrorMessage = "mellem 0-100 kr.")]
        [Display(Name = "Pris")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Regne formular")]
        public decimal IngredientCalculation { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

    }
}