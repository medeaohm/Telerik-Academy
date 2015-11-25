/*
 * Algo Academy February 2013 – Problem 04 – Salaries
 * http://bgcoder.com/Contests/Practice/Index/63#0
 */

namespace AlgoAcademy
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Using adjancency list and recursively DFS
    /// </summary>
    public class Salaries
    {
        private static readonly IDictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        private static long[] employees;

        public static void Main()
        {
            ParseInput();
            Console.WriteLine(CalculateTotalSalary());
        }

        private static void ParseInput()
        {
            var n = int.Parse(Console.ReadLine());
            employees = new long[n];

            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                adjacencyList[i] = new List<int>();

                for (int j = 0; j < n; j++)
                {
                    if (inputLine[j] == 'Y')
                    {
                        adjacencyList[i].Add(j);
                    }                    
                }

                if (adjacencyList[i].Count == 0)
                {
                    employees[i] = 1;
                }
            }
        }

        private static long CalculateTotalSalary()
        {
            long totalSalary = 0;

            for (int i = 0; i < employees.Length; i++)
            {
                totalSalary += Calculate(i);
            }

            return totalSalary;
        }

        private static long Calculate(int employeeId)
        {
            if (employees[employeeId] != 0)
            {
                return employees[employeeId];
            }

            foreach (var employee in adjacencyList[employeeId])
            {
                employees[employeeId] += Calculate(employee);
            }

            return employees[employeeId];
        }
    }
}
