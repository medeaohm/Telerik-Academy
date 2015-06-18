namespace Cosmetics.Products
{
    using System;

    using Common;
    using Contracts;

    public class Toothpaste : Product, IToothpaste
    {
        private string ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, string ingredients)
            : base(name, brand, price, gender)
        {
            this.Ingredients = ingredients;
        }

        public string Ingredients 
        {
            get { return this.ingredients; }
            private set
            {
                string[] allIngredients = value.Split(','); //remove empy entries if needed
                foreach (var ing in allIngredients)
                {
                    Validator.CheckIfStringLengthIsValid(ing, 12, 4, string.Format(GlobalErrorMessages.InvalidStringLength, ing, 4, 12));
                }
                this.ingredients = value;
                Validator.CheckIfStringIsNullOrEmpty(value, String.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Ingredients"));
            }
        }

        public override string Print()
        {
            string[] listOfIngredients = this.Ingredients.Split(','); //remove empy entries if needed
            return base.Print() + string.Format("  * Ingredients: {0}", string.Join(", ", listOfIngredients));
        }
    }
}
