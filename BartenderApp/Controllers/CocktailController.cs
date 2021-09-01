using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BartenderApp.Models;

namespace BartenderApp.Controllers
{
    public class CocktailController : Controller
    {

        private ICocktailRepository repository;
        public CocktailController(ICocktailRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ViewResult Order() => View(repository.Cocktails);

        [HttpPost]
        public ViewResult Edit(int cocktailId) =>
 View(repository.Cocktails
 .FirstOrDefault(p => p.CocktailID == cocktailId));

        public ViewResult Create() => View("Edit", new Cocktail());


    }
}
