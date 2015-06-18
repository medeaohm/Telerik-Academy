namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainStAndW
    {
        public static void Main()
        {
            List<Student> students = LoadStudents()
                .OrderBy(x => x.Grade)
                .ToList();

            List<Worker> workers = LoadWorkers()
                .OrderByDescending(x => x.MoneyPerHour())
                .ToList();

            Console.WriteLine("Students ordered by grade: ");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("\nWorkers ordered by descending money per hour: ");
            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            var merged = new List<Human>();
            merged.AddRange(students);
            merged.AddRange(workers);
            merged = merged.OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            Console.WriteLine("\nMerged students and workers (sorted by first then by last name:");
            Console.WriteLine(String.Join(" / ", merged.Select(x => String.Format("{0} {1}", x.FirstName, x.LastName))));
        }

        private static List<Student> LoadStudents()
        {
            List<Student> workers = new List<Student>();

            workers.Add(new Student("Niki", "Krastev", 99.0));
            workers.Add(new Student("Marin", "Kenov", 97.0));
            workers.Add(new Student("Nikolay", "Peshev", 98.0));
            workers.Add(new Student("Pesho", "Georgiev", 96.0));
            workers.Add(new Student("Ivan", "Nikolov", 92.0));
            workers.Add(new Student("Kosta", "Nikolaev", 10.0));
            workers.Add(new Student("Yavor", "Ivov", 11.0));
            workers.Add(new Student("Adrian", "Hristov", 12.0));
            workers.Add(new Student("Hristian", "Rizov", 13.0));
            workers.Add(new Student("Gosho", "Zdravkov", 14.0));

            return workers;
        }

        private static List<Worker> LoadWorkers()
        {
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Mariya", "Ilieva", 1050.0, 6));
            workers.Add(new Worker("Nikoleta", "Losanova", 820.0, 8));
            workers.Add(new Worker("Ivan", "Vazov", 1860.0, 5));
            workers.Add(new Worker("Dimitar", "Talev", 820.0, 4));
            workers.Add(new Worker("Robin", "Hood", 2420.0, 10));
            workers.Add(new Worker("George", "Cloney", 1234.0, 9));
            workers.Add(new Worker("Ivo", "Ivaylov", 500.0, 8));
            workers.Add(new Worker("Mitko", "Donkov", 861.0, 8));
            workers.Add(new Worker("Hristo", "Eremiev", 821.0, 4));
            workers.Add(new Worker("Georgi", "Zdravkov", 421.0, 4));

            return workers;
        }
    }
}
