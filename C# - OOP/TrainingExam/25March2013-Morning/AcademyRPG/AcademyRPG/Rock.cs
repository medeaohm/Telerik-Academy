/*
 •	Implement a command to create a Rock. The Rock should not be able to move. The command should set the HitPoints of the Rock. The Rock should be a resource with a Type property equal to Stone. The Quantity of the Rock should be half it’s HitPoints. The Rock should always be neutral and have a position.
 */

namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Rock : StaticObject, IResource
    {
        public Rock(int hitPoints, Point position) :
            base(position, 0)
        {
            this.HitPoints = hitPoints;
        }
        public int Quantity
        {
            get { return this.HitPoints/2; }
        }

        public ResourceType Type
        {
            get { return ResourceType.Stone; }
        }
    }
}
