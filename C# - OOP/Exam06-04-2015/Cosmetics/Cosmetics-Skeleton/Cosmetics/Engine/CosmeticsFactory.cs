namespace Cosmetics.Engine
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;
    using System.Text;

    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {         
                ICategory cat = new Category(name);
                return cat;
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            return new Shampoo(name, brand, price, gender, milliliters, usage);
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            var allIngredients = new StringBuilder();
            for (int i = 0; i < ingredients.Count - 1; i++)
            {
                allIngredients.Append(ingredients[i]);
                allIngredients.Append(",");
            }
            allIngredients.Append(ingredients[ingredients.Count - 1]);
            return new Toothpaste(name, brand, price, gender, allIngredients.ToString()); // check if works correctly
        }

        public IShoppingCart ShoppingCart()
        {
            return new ShoppingCart();
        }
    }
}
