namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Battles;
    using Logic.Specialties;
    using System;
    using System.Globalization;

    /*
     •	Add class AddAttackWhenSkip. The AddAttackWhenSkip is a specialty that adds attack points to the permanent attack points of the creature and is applied when creature skips its turn.
o	The class should have only one constructor which accepts integer argument (between 1 and 10, inclusive) – the value to add to the permanent attack of the creature during skip action in battle.
o	Override the default ToString() implementation to return the name of the specialty with the number of attack to add in parentesis. Example: “AddAttackWhenSkip(3)”

     */

    public class AddAttackWhenSkip : Specialty
    {
        private readonly int attackToAdd;

        public AddAttackWhenSkip(int attackToAdd)
        {
            if (attackToAdd < 1 || attackToAdd > 10)
            {
                throw new ArgumentOutOfRangeException("attackToAdd", "attackToAdd should be between 1 and 10, inclusive");
            }

            this.attackToAdd = attackToAdd;
        }

        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.attackToAdd;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.attackToAdd);
        }
    }
}
