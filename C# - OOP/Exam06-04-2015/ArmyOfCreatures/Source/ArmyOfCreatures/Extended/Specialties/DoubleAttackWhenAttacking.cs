namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Battles;
    using Logic.Specialties;
    using System;
    using System.Globalization;

    /*
     * •	Add class DoubleAttackWhenAttacking. The DoubleAttackWhenAttacking is a specialty. It doubles the current attack when creature is attacking.
o	The class should have only one constructor that accepts one argument – the number of rounds for the specialty to has effect. After these rounds the effect of this specialty stops.
	The number of rounds in the constructor should be greater than 0
o	Override the default ToString() implementation to return the name of the specialty with the number of rounds left in parentesis. Example: “DoubleAttackWhenAttacking(4)”

     */

    public class DoubleAttackWhenAttacking : Specialty
    {
        private int? rounds;

        public DoubleAttackWhenAttacking(int? rounds)
        {
            if (rounds == null)
            {
                throw new ArgumentNullException("rounds");
            }
            if (rounds < 1)
            {
                throw new ArgumentNullException("rounds should be between 1 and 10");
            }
            this.rounds = rounds;
        }

        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
            
            int initialAttack = attackerWithSpecialty.CurrentAttack;

            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return;
            }

            attackerWithSpecialty.CurrentAttack = attackerWithSpecialty.CurrentAttack * 2;
            this.rounds--;  
        }

        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "{0}({1})",
                base.ToString(),
                this.rounds);
        }
    }
}
