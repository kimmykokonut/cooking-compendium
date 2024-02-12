using System;
using System.Collections.Generic;

namespace RecipeBox.Models;

public class Ingredient
{
  public int IngredientId { get; set; }
  public string Name { get; set; }
  public int RecipeId { get; set; }
  public Recipe Recipe { get; set; }
}
