namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

/*    Implement a Weapon Supplement
      A Weapon is a Supplement, which increases the Power of a Unit by 10 and its Aggression by 3, but only if the Unit already has a WeaponrySkill Supplement. If not, the Weapon Supplement does not have any effect. 
 */

    public class Weapon : SupplementBase
    {
        private const int WeaponPowerEffect = 10;
        private const int WeaponAgressionEffect = 3;

        public Weapon () : base (0,0,0)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.PowerEffect = Weapon.WeaponPowerEffect;
                this.AggressionEffect = Weapon.WeaponAgressionEffect;
            }
        }
    }

}
