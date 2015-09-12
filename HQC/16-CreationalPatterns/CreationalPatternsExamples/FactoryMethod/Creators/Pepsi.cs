namespace FactoryMethod
{
    // "Concrete Creator A" 
    public class Pepsi : Creator
    {
        public override Product FactoryMethod()
        {
            return new SevenUp();
        }
    }
}
