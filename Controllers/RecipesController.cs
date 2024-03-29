using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;
using CookingAssist.Dtos;
using Microsoft.AspNetCore.Mvc;
using CookingAssist.Data;


namespace CookingAssist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {

        private readonly IRecipeRepository _repo;
        private readonly IMapper _mapper;
        public RecipesController(IRecipeRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        // GET api/recipes
        [HttpGet]
        public async Task<IActionResult> GetRecipes()
        {
            var recipes = await _repo.GetRecipes();
            if (recipes == null)
                return NotFound(new RecipesForReturnDto("Failure"));
            
            var recipeForListDto = _mapper.Map<IEnumerable<RecipeForListDto>>(recipes);
            var recipeForReturnDto = new RecipesForReturnDto("Success", recipeForListDto);
            return Ok(recipeForReturnDto);
        }

        // GET api/recipes{id}
        [HttpGet("{id}", Name = "GetRecipes")]
        public async Task<IActionResult> GetRecipes(int id)
        {
            var recipe = await _repo.GetRecipe(id);
            if (recipe == null)
                return NotFound(new RecipeForReturnDto("Failure"));

            var recipeForListDto = _mapper.Map<RecipeForListDto>(recipe);
            var recipeForReturnDto = new RecipeForReturnDto("Success", recipeForListDto);
            return Ok(recipeForReturnDto);
        }
    }
}