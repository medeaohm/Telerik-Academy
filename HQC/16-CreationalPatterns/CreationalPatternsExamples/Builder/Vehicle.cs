﻿namespace Builder
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Vehicle
    {
        private string vehicleType;
        private Dictionary<string, string> parts = new Dictionary<string, string>();

        // Constructor
        public Vehicle(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        // Indexer
        public string this[string key]
        {
            get 
            { 
                return this.parts[key]; 
            }

            set
            { 
                this.parts[key] = value; 
            }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", this.vehicleType);
            Console.WriteLine(" Frame : {0}", this.parts["frame"]);
            Console.WriteLine(" Engine : {0}", this.parts["engine"]);
            Console.WriteLine(" #Wheels: {0}", this.parts["wheels"]);
            Console.WriteLine(" #Doors : {0}", this.parts["doors"]);
        }
    }
}
