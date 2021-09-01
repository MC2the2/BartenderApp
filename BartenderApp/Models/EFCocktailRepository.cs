using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class EFCocktailRepository : ICocktailRepository
    {
        private ApplicationDbContext context;
        public EFCocktailRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Cocktail> Cocktails => context.Cocktails;

        public void SaveCocktail(Cocktail cocktail)
        {
            if (cocktail.CocktailID == 0)
            {
                context.Cocktails.Add(cocktail);
            }
            else
            {
                Cocktail dbEntry = context.Cocktails
                .FirstOrDefault(c => c.CocktailID == cocktail.CocktailID);
                if (dbEntry != null)
                {
                    dbEntry.Name = cocktail.Name;
                    dbEntry.CustomerName = cocktail.CustomerName;
                    dbEntry.Price = cocktail.Price;
                }
            }
            context.SaveChanges();
        }
    }
}
