using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookingAssist.Helpers;
using CookingAssist.Models;
using Microsoft.EntityFrameworkCore;

namespace CookingAssist.Data
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly DataContext _context;

        public RecipeRepository(DataContext context)
        {
            _context = context;

        }

        public async Task<IEnumerable<Recipe>> GetRecipes()
        {
            var recipes = await _context.recipes.ToListAsync();
            return recipes;
        }
    }
}