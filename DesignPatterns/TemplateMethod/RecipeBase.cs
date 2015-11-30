using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethod
{
    public abstract class RecipeBase
    {
        public void PrepareDish()
        {
            GetIngrdients();
            MixIngredients();
            CookIngredients();
        }

        protected abstract void GetIngrdients();

        protected abstract void MixIngredients();

        protected abstract void CookIngredients();
    }
}
