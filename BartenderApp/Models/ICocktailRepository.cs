using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public interface ICocktailRepository
    {
        IEnumerable<Cocktail> Cocktails { get; }
        void SaveCocktail(Cocktail cocktail);
    }
}
