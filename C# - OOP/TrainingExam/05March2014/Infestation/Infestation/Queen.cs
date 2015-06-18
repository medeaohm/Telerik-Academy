/*
 * Implement a Queen
	The Queen is a type of Unit, which can infest
	Infesting is equivalent to adding an InfestationSpores Supplement to the target
	The Queen has a base Health of 30 and all of its other base values are set to 1
	The Queen is classified as a Psionic Unit
	The Queen interacts in the same way as the Parasite
 */

namespace Infestation
{
    public class Queen : InfestingUnit
    {
        public Queen(string id) : base (id, UnitClassification.Psionic, 30, 1, 1)
        {

        }
    }
}
