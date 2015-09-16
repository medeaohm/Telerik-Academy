namespace Decorator
{
    public class CherryDecorator : Decorator
    {
        public CherryDecorator(IBakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Cherry";
            this.m_Price = 2.0;
        }
    }
}
