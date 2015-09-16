namespace Decorator
{
    public class CreamDecorator : Decorator
    {
        public CreamDecorator(IBakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Cream";
            this.m_Price = 1.0;
        }
    }
}
