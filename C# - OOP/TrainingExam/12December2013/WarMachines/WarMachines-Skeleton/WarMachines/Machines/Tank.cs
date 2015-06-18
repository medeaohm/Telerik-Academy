namespace WarMachines.Machines
{
    using Interfaces;

    public class Tank : Machine, ITank
    {
        private const double TankInitialHealt = 100;
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints)
            : base (name, TankInitialHealt, attackPoints, defensePoints)
        {
            this.defenseMode = true;
            this.DefensePoints += 30;
            this.AttackPoints -= 40;
        }
        
        public bool DefenseMode
        {
            get
            {
                return this.defenseMode;
            }
            set
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.DefenseMode = false;
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
            else
            {
                this.DefenseMode = true;
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n *Defense: {0}", this.DefenseMode == true ? "ON" : "OFF");
        }
    }
}
