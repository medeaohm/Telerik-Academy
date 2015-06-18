/*
  Implement a command to create a Knight. The Knight should be able to move and to execute attack commands. The Knight should have 100 AttackPoints, 100 DefensePoints and 100 HitPoints. The knight should have an owner, name, and position. When attacking, the Knight should always pick the first available target to attack, which is not neutral and does not belong to the same player as the Knight.
 */

namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Knight : Character, IFighter
    {
        public Knight(string name, Point position, int owner)
            : base(name, position, owner)
        {
            this.HitPoints = 100;
        }

        public int AttackPoints
        {
            get { return 100; }
        }

        public int DefensePoints
        {
            get { return 100; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
