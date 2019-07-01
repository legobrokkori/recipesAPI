using System.Collections.Generic;
using System.Threading.Tasks;
using CookingAssist.Models;

namespace CookingAssist.Data
{
    public interface IRecipeRepository
    {
         Task<IEnumerable<Recipe>> GetRecipes();
    }
}