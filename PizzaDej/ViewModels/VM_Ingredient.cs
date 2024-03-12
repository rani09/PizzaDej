using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaDej.ViewModels
{
    public class VM_Ingredient_List
    {
        public int IngredientId { get; set; }

        [Required, MinLength(2, ErrorMessage = "Min 2 tegn"), MaxLength(20, ErrorMessage = "Max 20 tegn")]
        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Display(Name = "Oprette den")]
        public DateTime DateCreated { get; set; }

        [Required, Range(0, 100, ErrorMessage = "mellem 0-100 kr.")]
        [Display(Name = "Pris")]
        public decimal Price { get; set; }

        [Display(Name = "Vælge Type")]
        public int IngredientTypeId { get; set; }

        [Required]
        [Display(Name = "Type")]
        public string IngredientType { get; set; }
    }

    public class VM_Ingredient_Create
    {
        [Required, MinLength(2, ErrorMessage = "Min 2 tegn"), MaxLength(20, ErrorMessage = "Max 20 tegn")]
        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Required, Range(0, 100, ErrorMessage = "mellem 0-100 kr.")]
        [Display(Name = "Pris")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Type")]
        public int IngredientId { get; set; }

        [Display(Name = "Vælge Type")]
        public int IngredientTypeId { get; set; }

        //[Required]
        //[Display(Name = "Type")]
        //public string IngredientType { get; set; }
    }

    public class VM_Ingredient_Edit
    {
        public int CrustId { get; set; }

        [Required, MinLength(2, ErrorMessage = "Min 2 tegn"), MaxLength(20, ErrorMessage = "Max 20 tegn")]
        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Required, Range(0, 100, ErrorMessage = "mellem 0-100 kr.")]
        [Display(Name = "Pris")]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Type")]
        public int IngredientId { get; set; }

        [Display(Name = "Vælge Type")]
        public int IngredientTypeId { get; set; }

    }
}