namespace FactoryMethod
{
    // "Concrete Creator B" 
    public class CocaCola : Creator
    {
        public override Product FactoryMethod()
        {
            return new Sprite();
        }
    }
}
