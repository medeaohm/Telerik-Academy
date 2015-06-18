/*
 •	Implement a command to create a Ninja. The Ninja should be able to move and to execute attack commands. The Ninja should have 1 HitPoints, but should be invulnerable – it should not be able to be destroyed by other objects. The Ninja should initially have no AttackPoints. The Ninja should be able to gather stone and lumber resources. For each lumber resource the Ninja has gathered, its AttackPoints should increase by the resource’s quantity. For each stone resource the Ninja has gathered, its AttackPoints should increase by the resource’s quantity multiplied by 2. The Ninja should have an owner, specified by the command. The Ninja should have a name and position. The Ninja should always attack the target, which is not neutral, does not belong to the same player, and has the highest HitPoints of all the available targets.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IGatherer, IFighter
    {
        private int attackPoints = 0;
        protected int Owner { get; set; }

        bool IsDestroyed
        {
            get { return false; }
        }

        public Ninja (string name, Point position, int owner)
            :base(name, position, owner)
        {
            this.Owner = owner;
            this.HitPoints = 1;
        }

        public int AttackPoints
        {
            get { return this.attackPoints; }
        }

        public int DefensePoints
        {
            get { return Int32.MaxValue; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int objectWithMaxHitPoints = availableTargets.Where(x => x.Owner != 0 && x.Owner != this.Owner).Max(x => x.HitPoints);
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != 0 && availableTargets[i].Owner != this.Owner && availableTargets[i].HitPoints == objectWithMaxHitPoints)
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
                this.attackPoints += resource.Quantity * 2;
                return true;
            }
            if (resource.Type == ResourceType.Lumber)
            {
                this.attackPoints += resource.Quantity;
                return true;
            }
            return false;
        }
    }
}
