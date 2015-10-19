namespace Computers.Utilities.Components
{
    public class Cpu64 : Cpu
    {
        public Cpu64(byte numberOfCores) :
            base(numberOfCores)
        {
        }

        internal override int GetMaxNumber()
        {
            return 1000;
        }
    }
}
