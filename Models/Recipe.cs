namespace CookingAssist.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string MakingTitle { get; set; }
        public string Serves { get; set; }
        public string Ingredients { get; set; }
        public string Cost { get; set; }
    }
}