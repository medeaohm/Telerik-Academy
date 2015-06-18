namespace ArmyOfCreatures.Extended.Creatures
{
    using Logic.Creatures;

    /* The Goblin is a creature with attack 4, defence 2, health points 5 and damage 1.5 and has no specialties*/

    public class Goblin : Creature
    {
        public Goblin ()
            : base (4, 2, 5, 1.5M)
        {

        }
    }
}
