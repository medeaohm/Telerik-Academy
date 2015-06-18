/* 
 * 	Implement a Parasite
	    The Parasite is a type of Unit, which can Infest
	    Infesting is equivalent to adding an InfestationSpores Supplement to the target
	    The Parasite is classified as a Biological Unit. 
	    The Parasite has all base values set to 1
	    When a Parasite is offered to Interact, it always tries to find a Unit to infest
	    The target Unit can be any unit different than itself
	    If there are multiple such units, the Parasite picks the one with the least Health
*/

namespace Infestation
{
    public class Parassite : InfestingUnit
    {
        public Parassite(string id) : base (id, UnitClassification.Biological, 1, 1, 1)
        {

        }
    }
}
