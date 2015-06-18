namespace ArmyOfCreatures.Extended.Creatures
{
    using Logic.Creatures;
    using Extended.Specialties;

    /*
     •	Add class CyclopsKing. The CyclopsKing is a creature with attack 17, defense 13, damage 18, health points 70 and the following specialties:
o	AddAttackWhenSkip with 3 attack points for each skip action.
o	DoubleAttackWhenAttacking for 4 rounds
o	DoubleDamage for 1 round

     */
    public class CyclopsKing : Creature
    {
        public CyclopsKing()
            : base (17, 13, 70, 18M)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
