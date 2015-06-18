//•	Implement a command to create a Boar. The Boar should be an animal and should have a Size of 4. The Boar should be able to eat any animal, which is smaller than him or as big as him. The Boar should be able to eat from any plant. The Boar always has a bite size of 2. When eating from a plant, the Boar increases its size by 1.

namespace AcademyEcosystem
{
    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private const int biteSize = 2;
        private const int BoarSize = 4;

        public Boar(string name, Point location)
            : base(name, location, BoarSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (animal.Size <= this.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }
            return 0;
        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(biteSize);
            }
            return 0;
        }
    }
}
