using System;

namespace DesignPatterns.TemplateMethod
{
    public class CakeRecipe : RecipeBase
    {
        protected override void CookIngredients()
        {
            Console.WriteLine("I cooked cake base, sprinklers and icecreams.");
        }

        protected override void GetIngrdients()
        {
            Console.WriteLine("I got cake base, sprinklers and icecreams.");
        }

        protected override void MixIngredients()
        {
            Console.WriteLine("I mixed cake base, sprinklers and icecreams.");
        }
    }
}
