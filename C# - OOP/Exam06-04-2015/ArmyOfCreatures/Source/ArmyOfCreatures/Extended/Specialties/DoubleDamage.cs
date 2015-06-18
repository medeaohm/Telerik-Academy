namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    using Logic.Specialties;
    using Logic.Battles;

    /*
     •	Add class DoubleDamage. The DoubleDamage is a specialty that doubles the current damage during battle.
o	The DoubleDamage class should have only one constructor that accepts one argument – the number of rounds for the specialty to has effect. After these rounds (attacks) the effect of this specialty stops.
-	The number of rounds in the constructor should be greater than 0
-   The number of rounds in the constructor should be less than or equal to 10
o	Override the default ToString() implementation to return the name of the specialty with the number of rounds remaning in parentesis. Example: “DoubleDamage(7)”

     */

    public class DoubleDamage : Specialty
    {
        private int? numberOfRounds;

        public DoubleDamage(int? numberOfRounds)
        {
            if (numberOfRounds == null)
            {
                throw new ArgumentNullException("numberOfRounds");
            }
            if (numberOfRounds < 1 || numberOfRounds > 10)
            {
                throw new ArgumentNullException("numberOfRounds should be between 1 and 10");
            }
            this.numberOfRounds = numberOfRounds;
        }

        public override decimal ChangeDamageWhenAttacking(
            ICreaturesInBattle attackerWithSpecialty,
            ICreaturesInBattle defender,
            decimal currentDamage)
        {
            //decimal initialDamage = attackerWithSpecialty.Creature.Damage;
            var damage = currentDamage;
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            if (this.numberOfRounds <= 0)
            {
                // Effect expires after fixed number of rounds
                damage = currentDamage;
            }
            else 
            {
                damage = currentDamage * 2;
                this.numberOfRounds--;
            }
            return damage;
        }

        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "{0}({1})",
                base.ToString(),
                this.numberOfRounds);
        }
    }
}
