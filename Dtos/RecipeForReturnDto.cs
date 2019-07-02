namespace CookingAssist.Dtos
{
    public class RecipeForReturnDto
    {
        public string Message { get; private set; }
        public RecipeForListDto Recipe { get; private set; }

        public RecipeForReturnDto(string message, RecipeForListDto recipe = null)
        {
            Message = message;
            Recipe = recipe;
        }
    }
}