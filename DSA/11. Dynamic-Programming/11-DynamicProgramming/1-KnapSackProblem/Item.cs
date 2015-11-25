namespace KnapSackProblem
{
    public class Item
    {
        public Item(string name, int weigth, int price)
        {
            this.Name = name;
            this.Weigth = weigth;
            this.Price = price;
        }

        public string Name
        {
            get; set;
        }

        public int Weigth
        {
            get; set;
        }

        public int Price
        {
            get; set;
        }

        public override string ToString()
        {
            return "Name = " + this.Name + ", Weigth = " + this.Weigth + ", Price = " + this.Price;
        }
    }
}