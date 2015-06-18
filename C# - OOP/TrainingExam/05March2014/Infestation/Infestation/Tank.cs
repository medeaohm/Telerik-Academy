namespace Infestation
{
    /*	The Tank has a base Power of 25, a base Health of 20, and a base Aggression of 25
        The Tank is classified as a Mechanical Unit. */

    public class Tank : Unit
    {
        const int TankPower = 25;
        const int TankHealth = 20;
        const int TankAggression = 25;

        public Tank(string id)
            : base (id, UnitClassification.Mechanical, Tank.TankHealth, Tank.TankPower, Tank.TankAggression)
        {

        }
    }
}
