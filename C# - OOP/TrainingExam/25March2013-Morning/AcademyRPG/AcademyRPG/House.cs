/*
  Implement a command to create a House. The House should not be able to move. The house should have 500 HitPoints. The house should have a position and an owner.
 */

namespace AcademyRPG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class House :StaticObject
    {
        public House (Point position, int owner)
            :base(position, owner)
        {
            this.HitPoints = 500;
        }
    }
}
