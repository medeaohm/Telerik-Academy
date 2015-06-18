﻿namespace FurnitureManufacturer.Models
{
    using Interfaces;

    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;

        public Table(string model, MaterialType matType, decimal price, decimal height, decimal length, decimal width)
            :base (model, matType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length { get; private set; }

        public decimal Width { get; private set; }

        public decimal Area
        {
            get 
            {
                return this.Width * this.Length;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", Length: {0}, Width: {1}, Area: {2}", this.Length, this.Width, this.Area) ;
        }
    }
}
