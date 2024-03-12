using PizzaDej.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaDej.ViewModels
{
    public class VM_View_Home_Index
    {
        public List<Crust> Crusts { get; set; }
        public List<Ingredient> Ingredients { get; set; }
    }
}