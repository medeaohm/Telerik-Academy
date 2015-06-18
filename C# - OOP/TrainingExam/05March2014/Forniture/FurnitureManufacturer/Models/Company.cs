namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Interfaces;

    public class Company : ICompany
    {
        private const int MinLenghtCompanyName = 5;
        private const int RegistrationNumLenght = 10;

        private string name;
        private string registrationNumber;
        private readonly ICollection<IFurniture> furnitures;

        public Company (string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get 
            { 
                return this.name; 
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Company name cannot be null or empty!");
                }
                if (value.Length < MinLenghtCompanyName)
                {
                    throw new ArgumentException("Company Name cannot with less than 5 symbols");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get 
            {
                return this.registrationNumber;
            }
            private set
            {
                if (value.Length != RegistrationNumLenght)
	            {
                    throw new ArgumentException("Registration Number must be exactly 10 digits");
	            }
                if (value.Any(ch => !char.IsDigit(ch)))
                {
                    throw new ArgumentException("Registration Number must contains only digits");
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get 
            {
                return new List<IFurniture>(this.furnitures);
            }
        }

        public void Add(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Cannot add a null furniture!");
            }
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Cannot remove a null furniture!");
            }
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var catalog = new StringBuilder();
            catalog.AppendFormat("{0} - {1} - {2} {3}\n", this.Name, this.RegistrationNumber, this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no", this.Furnitures.Count != 1 ? "furnitures" : "furniture");

            var sortedFurnitures = furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);

            foreach (var furniture in sortedFurnitures)
            {
                catalog.AppendLine(furniture.ToString());
            }
            return catalog.ToString().Trim();
        }
    }
}
