using System;
using System.Collections.Generic;

namespace CookingAssist.Dtos
{
    public class RecipesForReturnDto
    {
        public string Message { get; private set; }
        public IEnumerable<RecipeForListDto> Recipes { get; private set; }

        public RecipesForReturnDto(string message, IEnumerable<RecipeForListDto> recipes = null)
        {
            Message = message;
            Recipes = recipes;
        }
    }
}