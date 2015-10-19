namespace Computers.Utilities.Components
{
    public class Cpu32 : Cpu
    {
        public Cpu32(byte numberOfCores) :
            base(numberOfCores)
        {
        }

        internal override int GetMaxNumber()
        {
            return 500;
        }
    }
}
