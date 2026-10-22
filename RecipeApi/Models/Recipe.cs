namespace RecipeApi.Models;

public class Recipe
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Servings { get; set; }
    public List<Ingredient> Ingredients { get; set; } = [];
}
