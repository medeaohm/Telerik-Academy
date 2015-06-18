namespace ArmyOfCreatures.Extended.Creatures
{
    using Logic.Creatures;
    using Logic.Specialties;

    /*
Add class AncientBehemoth. The AncientBehemoth is a creature with attack 19, defense 19, damage 40, health points 300 and has the following specialties:
o	ReduceEnemyDefenseByPercentage specialty with 80% damage reduction
o	DoubleDefenseWhenDefending specialty for 5 rounds
     */

    public class AncientBehemoth : Creature 
    {
        public AncientBehemoth()
            : base(19, 19, 300, 40M)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(80));
            this.AddSpecialty(new DoubleDefenseWhenDefending(5));
        }
    }
}
