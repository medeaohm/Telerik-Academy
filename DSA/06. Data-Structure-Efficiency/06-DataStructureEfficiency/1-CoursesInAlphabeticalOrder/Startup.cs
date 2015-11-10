// 1. A text file `students.txt` holds information about students and their courses in the following format:
//  * Using `SortedDictionary<K, T>` print the courses in alphabetical order and for each of them prints the students ordered by family and then by name:

//    Kiril  | Ivanov   | C#
//    Stefka | Nikolova | SQL
//    Stela  | Mineva   | Java
//    Milena | Petrova  | C#
//    Ivan   | Grigorov | C#
//    Ivan   | Kolev    | SQL

//   C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
//   Java: Stela Mineva
//   SQL: Ivan Kolev, Stefka Nikolova

namespace CoursesInAlphabeticalOrder
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var records = File.ReadLines("../../../TextFiles/students.txt").ToList();

            SortedDictionary<string, string> coursesAndStudents = ParseInput(records);

            foreach (KeyValuePair<string, string> entry in coursesAndStudents)
            {
                Console.WriteLine("{0}: {1}", entry.Key, entry.Value);
            }

            Console.WriteLine();
        }

        private static SortedDictionary<string, string> ParseInput(List<string> records)
        {
            string[,] splittedRecords = new string[3, records.Count()];
            SortedDictionary<string, string> coursesAndStudents = new SortedDictionary<string, string>();

            for (int i = 0; i < records.Count(); i++)
            {
                var currentRecord = records[i].Split('|');
                var currentCourse = currentRecord[2].Trim();
                var currentStudent = currentRecord[0].Trim() + " " + currentRecord[1].Trim();

                if (coursesAndStudents.ContainsKey(currentCourse))
                {
                    var oldElement = coursesAndStudents.FirstOrDefault(c => c.Key == currentCourse);
                    var newElementValue = currentStudent;
                    var newElement = new KeyValuePair<string, string>(oldElement.Key, oldElement.Value + ", " + newElementValue);

                    coursesAndStudents.Remove(oldElement.Key);
                    coursesAndStudents.Add(newElement.Key, newElement.Value);
                }

                else
                {
                    coursesAndStudents.Add(currentCourse, currentStudent);
                }
            }

            return coursesAndStudents;
        }
    }
}