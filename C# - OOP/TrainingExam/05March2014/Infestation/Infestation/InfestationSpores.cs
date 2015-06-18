/*
Implement an InfestationSpores Supplement
The InfestationSpores Supplement does not accumulate like the other Supplements – even if two or more Infestations are added, the total AggressionEffect stays 20 (Edit: the same goes for PowerEffect)
The InfestationSpores Supplement cannot be added with the supplement command
 */

namespace Infestation
{
    public class InfestationSpores : SupplementBase
    {
        public InfestationSpores()
            : base (-1, 0, 20)
        {

        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.PowerEffect = 0;
                this.AggressionEffect = 0;
            }
        }
    }
}
