namespace ArmyOfCreatures.Extended.Creatures
{

    using Logic.Creatures;
    using Extended.Specialties;

    /*
     •	Add class WolfRaider. The WolfRaider is a creature with attack 8, defense 5, health points 10, damage 3.5 and:
o	DoubleDamage specialty for 7 rounds
     */

    public class WolfRaider : Creature
    {
        public WolfRaider()
            : base (8,5, 10, 3.5M)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}
