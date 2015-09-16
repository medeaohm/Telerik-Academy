namespace Decorator
{
    class CakeBase : IBakeryComponent
    {
        // In real world these values will typically come from some data store
        private string m_Name = "Cake Base";
        private double m_Price = 200.0;

        public string GetName()
        {
            return m_Name;
        }

        public double GetPrice()
        {
            return m_Price;
        }
    }
}
