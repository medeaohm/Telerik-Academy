namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public  abstract class SupplementBase : ISupplement
    {
        public SupplementBase (int powerEffect, int healtEffect, int aggressionEffect)
        {
            this.PowerEffect = powerEffect;
            this.HealthEffect = healtEffect;
            this.AggressionEffect = aggressionEffect;
        }


        public int PowerEffect { get; protected set; }

        public int HealthEffect { get; protected set; }

        public int AggressionEffect { get; protected set; }

        public virtual void ReactTo(ISupplement otherSupplement)
        {
        }

    }
}
