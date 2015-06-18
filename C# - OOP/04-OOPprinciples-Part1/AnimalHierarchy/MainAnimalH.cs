namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainAnimalH
    {
        static void Main(string[] args)
        {
            Kitten maca = new Kitten("Maca", 2);
            Tomcat tom = new Tomcat("Tom", 3);
            Frog hero = new Frog("Hero", 1, Gender.Male);
            Dog rex = new Dog("Rex", 4, Gender.Male);
            Cat fortuna = new Cat("Fortuna", 3, Gender.Female);

            List<Animal> animals = new List<Animal>() { maca, tom, hero, rex, fortuna };
            PrintAnimals(animals);

            Kitten[] kittens = new Kitten[] { maca, new Kitten("Lilly", 1), new Kitten("Smurf", 2) };
            Tomcat[] tomcats = new Tomcat[] { tom, new Tomcat("Gandalf", 5), new Tomcat("Myri", 2), new Tomcat("Steaven", 12) };
            Frog[] frogs = new Frog[] { hero, new Frog("Ivan", 12, Gender.Female), new Frog("Kurt", 1, Gender.Male) };
            Dog[] dogs = new Dog[] { rex, new Dog("Joy", 12, Gender.Female), new Dog("Sharo", 12, Gender.Male) };
            Cat[] cats = new Cat[] { fortuna };

            Console.WriteLine("Kittens: {0:F2}", Animal.AverageAge(kittens));
            Console.WriteLine("Tomcats: {0:F2}", Animal.AverageAge(tomcats));
            Console.WriteLine("Frogs: {0:F2}", Animal.AverageAge(frogs));
            Console.WriteLine("Dogs: {0:F2}", Animal.AverageAge(dogs));
            Console.WriteLine("Cats: {0:F2}", Animal.AverageAge(cats));
        }

        private static void PrintAnimals(List<Animal> animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
