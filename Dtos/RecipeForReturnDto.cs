using System;
using System.Collections.Generic;

namespace CookingAssist.Dtos
{
    public class RecipeForReturnDto
    {
        public string Message { get; private set; }
        public IEnumerable<RecipeForListDto> Recipes { get; private set; }

        public RecipeForReturnDto(string message, IEnumerable<RecipeForListDto> recipes = null)
        {
            Message = message;
            Recipes = recipes;
        }
    }
}