using System;

namespace DesignPatterns.TemplateMethod
{
    public class BurritoRecipe : RecipeBase
    {
        protected override void CookIngredients()
        {
            Console.WriteLine("I heated a bowl of rice, cilantro, cheeze and lettuce.");
        }

        protected override void GetIngrdients()
        {
            Console.WriteLine("I got rice, cilantro, cheeze and lettuce.");
        }

        protected override void MixIngredients()
        {
            Console.WriteLine("I mixed rice, cilantro, cheeze and lettuce.");
        }
    }
}
