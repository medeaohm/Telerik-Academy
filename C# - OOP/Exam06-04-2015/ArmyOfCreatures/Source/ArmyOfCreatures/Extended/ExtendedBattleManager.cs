namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Logic.Battles;
    using ArmyOfCreatures.Logic;

    public class ExtendedBattleManager : BattleManager
    {
        private readonly ICollection<ICreaturesInBattle> firstArmyCreatures;
        private readonly ICollection<ICreaturesInBattle> secondArmyCreatures;
        private readonly ICollection<ICreaturesInBattle> thirdArmyCreatures;

        private readonly ICreaturesFactory creaturesFactory;

        private readonly ILogger logger;

        public ExtendedBattleManager(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.firstArmyCreatures = new List<ICreaturesInBattle>();
            this.secondArmyCreatures = new List<ICreaturesInBattle>();
            this.thirdArmyCreatures = new List<ICreaturesInBattle>();
            this.creaturesFactory = creaturesFactory;
            this.logger = logger;
        }
        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thirdArmyCreatures.Add(creaturesInBattle);
            }
            else
            {
                base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
            }
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            if (identifier.ArmyNumber == 3)
            {
                return this.thirdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);
            }
            else
            {
                return base.GetByIdentifier(identifier);
            }  
        }
    }
}
