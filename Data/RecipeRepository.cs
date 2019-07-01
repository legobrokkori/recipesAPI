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

        public async Task<List<Recipe>> GetRecipes()
        {
            var recipes = await _context.Recipes.ToListAsync();
            return recipes;
        }
    }
}