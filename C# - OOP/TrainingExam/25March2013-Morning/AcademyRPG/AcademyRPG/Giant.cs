/*
 •	Implement a command to create a Giant. The Giant should be able to move and to execute attack commands. It should have 150 AttackPoints, 80 DefensePoints and 200 HitPoints. It should have a name and a position, but should be always neutral. The Giant should also be able to gather Stone resources. When a Giant gathers such a resource, his AttackPoints are permanently increased by 100. This should only work once. When attacking, the Giant should pick the first available target, which is not neutral.
 */

namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Giant : Character, IFighter, IGatherer
    {
        private int attackPoints = 150;
        private int defensePoints = 80;
        private bool isIncreased = false;

        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = 200;
        }

        public int AttackPoints
        {
            get { return attackPoints; }
        }

        public int DefensePoints
        {
            get { return defensePoints; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (isIncreased == false)
                {
                    isIncreased = true;
                    this.attackPoints += 100;
                }
                return true;
            }
            return false;
        }
    }
}
