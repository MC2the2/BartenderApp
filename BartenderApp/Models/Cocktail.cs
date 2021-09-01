using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BartenderApp.Models
{
    public class Cocktail
    {
        public int CocktailID { get; set; }
        [Required(ErrorMessage = "Please select a cocktail name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the customer name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please enter the size")]
        public decimal Price { get; set; }
    }
}
