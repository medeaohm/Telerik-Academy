namespace WarMachines.Machines
{
    using Interfaces;

    public class Fighter : Machine, IFighter
    {

        private const double FighterInitialHealt = 200;
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool initialSteathMode)
            : base (name, FighterInitialHealt, attackPoints, defensePoints)
        {
            this.StealthMode = initialSteathMode;
        }

        public bool StealthMode
        {
            get 
            {
                return this.stealthMode;
            }
            set
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.StealthMode)
            {
                this.StealthMode = false;
            }
            else
            {
                this.StealthMode = true;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n *Stealth: {0}", this.StealthMode == true ? "ON" : "OFF");
        }
    }
}
