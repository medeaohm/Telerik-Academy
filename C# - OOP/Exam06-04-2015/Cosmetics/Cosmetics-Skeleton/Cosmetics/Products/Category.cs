namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Common;
    using Contracts;

    public class Category : ICategory
    {
        private string name;
        public readonly IList<IProduct> allCosmetics;

        public Category(string name)
        {
            this.Name = name;
            this.allCosmetics = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }
            protected set
            {
                this.name = value;
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, value));
                Validator.CheckIfStringLengthIsValid(name, 15, 2, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", 2, 15));
            }
        }

        public IList<IProduct> Products
        {
            get
            {
                return new List<IProduct>(this.allCosmetics);
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            allCosmetics.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!allCosmetics.Contains(cosmetics))
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }
            else
            {
                allCosmetics.Remove(cosmetics);
            }    
        }

        public string Print()
        {
            var output = new StringBuilder();
            if (allCosmetics.Count == 0)
            {
                output.AppendFormat("{0} category - 0 products in total", this.Name);
            }
            else
            {
                output.AppendFormat("{0} category - {1} {2} in total\n", this.Name, this.allCosmetics.Count, this.allCosmetics.Count == 1 ? "product" : "products");
            }
            var sortedProducts = allCosmetics.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);
            foreach (var pr in sortedProducts)
            {             
                output.AppendLine(pr.Print());
            }
            return output.ToString().Trim();
        }
    }
}
