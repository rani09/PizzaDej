using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaDej.ViewModels
{
    public class VM_IngredientType_List
    {
        public int IngredientTypeId { get; set; }

        [Display(Name = "Navn")]
        public string Name { get; set; }

        [Display(Name = "Oprette den")]
        public DateTime DateCreated { get; set; }
    }

    public class VM_IngredientType_Create
    {
        [Required(ErrorMessage = "Skal Udfyldes"), MinLength(2, ErrorMessage = "Min 2 tegn"), MaxLength(20, ErrorMessage = "Max 20 tegn")]
        [Display(Name = "Navn")]
        public string Name { get; set; }

    }
    public class VM_IngredientType_Edit
    {
        public int IngredientTypeId { get; set; }

        [Required, MinLength(2, ErrorMessage = "Min 2 tegn"), MaxLength(20, ErrorMessage = "Max 20 tegn")]
        [Display(Name = "Navn")]
        public string Name { get; set; }

    }
}