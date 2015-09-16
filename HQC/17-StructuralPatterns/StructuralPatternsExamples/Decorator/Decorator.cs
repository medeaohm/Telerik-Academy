namespace Decorator
{
    public abstract class Decorator : IBakeryComponent
    {
        IBakeryComponent m_BaseComponent = null;

        protected string m_Name = "Undefined Decorator";
        protected double m_Price = 0.0;

        protected Decorator(IBakeryComponent baseComponent)
        {
            m_BaseComponent = baseComponent;
        }

        #region IBakeryComponent Members
        string IBakeryComponent.GetName()
        {
            return string.Format("{0}, {1}", m_BaseComponent.GetName(), m_Name);
        }

        double IBakeryComponent.GetPrice()
        {
            return m_Price + m_BaseComponent.GetPrice();
        }
        #endregion
    }
}
