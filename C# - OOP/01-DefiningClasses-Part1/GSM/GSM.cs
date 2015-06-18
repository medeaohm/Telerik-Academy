namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class GSM
    {
        public static readonly GSM iPhone6 = new GSM("iPhone 6", Manufacturer.APPLE, "Gosho", new Display(5.6, 16000000),
            new Battery(BatteryType.NiCd, 20, 80), 1800);


        private string model;
        private Manufacturer manufacturer;
        private Display display;
        private Battery battery;
        private string owner;
        private decimal price;


        public GSM (string model, Manufacturer manufacturer):base()
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, Manufacturer manufacturer, Battery battery)
            : this(model, manufacturer)
        {
            this.Battery = battery;
        }

        public GSM(string model, Manufacturer manufacturer, string owner)
            : this(model, manufacturer)
        {
            this.Owner = owner;
        }

        public GSM(string model, Manufacturer manufacturer, Display display)
            : this(model, manufacturer)
        {
            this.Display = display;
        }

        public GSM(string model, Manufacturer manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = Price;
        }

        public GSM(string model, Manufacturer manufacturer, decimal price, Battery battery)
            : this(model, manufacturer)
        {
            this.Battery = battery;
            this.Price = Price;
        }

        public GSM(string model, Manufacturer manufacturer, decimal price, string owner)
            : this(model, manufacturer)
        {
            this.Owner = owner;
            this.Price = Price;
        }

        public GSM(string model, Manufacturer manufacturer, decimal price, Display display)
            : this(model, manufacturer)
        {
            this.Display = display;
            this.Price = Price;
        }

        public GSM(string model, Manufacturer manufacturer, Battery battery, string owner)
            : this(model, manufacturer)
        {
            this.Owner = owner;
            this.Battery = battery;
        }

        public GSM(string model, Manufacturer manufacturer, Battery battery, Display display)
            : this(model, manufacturer)
        {
            this.Display = display;
            this.Battery = battery;
        }

        public GSM(string model, Manufacturer manufacturer, string owner, Display display)
            : this(model, manufacturer)
        {
            this.Display = display;
            this.Owner = owner;
        }

        public GSM(string model, Manufacturer manufacturer, string owner, Display display, Battery battery, decimal price)
            : this(model, manufacturer)
        {
            this.Battery = battery;
            this.Price = price;
            this.Display = display;
            this.Owner = owner;
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                this.owner = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public Manufacturer Manufacturer 
        {
            get 
            {
                if (manufacturer.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.manufacturer;
            } 
            private set
            {
                this.manufacturer = value;
            }
        }

        public Battery Battery 
        { 
            get
            {
                if (this.battery.Equals(null))
                {
                    throw new NullReferenceException();
                }
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }

        public decimal Price 
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price must be > 0");
                }
                this.price = value;
            }
        }

        public Display Display 
        { 
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Information about the GSM:");
            result.AppendLine("Manufacturer: " + this.manufacturer);
            result.AppendLine("Model: " + this.model);
            result.AppendLine("Price: " + this.price.ToString() + " lv");
            result.AppendLine("Owner: " + this.owner);
            result.AppendLine();
            result.AppendLine(battery.ToString());
            result.AppendLine(display.ToString());
            return result.ToString();
        }

        public List<Call> CallHistory
        {
            get { return this.CallHistory; }
        }

        public void AddCalls(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void DeleteCalls(Call call)
        {
            int index = CallHistory.IndexOf(call);
            if (index != -1)
            {
                this.CallHistory.RemoveAt(index);
            }
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public double CalculateTotalPrice(double pricePerMinute)
        {
            double spentMoney = 0.0;
            double entireDuration = 0.0;
            for (int i = 0; i < CallHistory.Count; i++)
            {
                entireDuration += CallHistory[i].Duration;
            }
            spentMoney += (entireDuration * pricePerMinute);
            return spentMoney;
        }
    }
 


    public enum Manufacturer
    {
        HTC,
        SAMSUNG,
        LG,
        MOTOROLA,
        NOKIA,
        APPLE,
    }
}
