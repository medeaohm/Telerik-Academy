namespace Decorator
{
    public class ArtificialScentDecorator : Decorator
    {
        public ArtificialScentDecorator(IBakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Artificial Scent";
            this.m_Price = 3.0;
        }
    }
}
