namespace Computers.Utilities.Components
{
    public class Cpu128 : Cpu
    {
        public Cpu128(byte numberOfCores) :
            base(numberOfCores)
        {
        }

        internal override int GetMaxNumber()
        {
            return 2000;
        }
    }
}
