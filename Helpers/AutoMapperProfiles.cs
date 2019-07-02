using AutoMapper;
using CookingAssist.Models;
using CookingAssist.Dtos;
using System.Collections.Generic;

namespace CookingAssist.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Recipe, RecipeForListDto>();
        }
    }
}