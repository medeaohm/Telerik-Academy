namespace OfficeSpace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //public class Program
    //{
    //    public static void Main()
    //    {
    //        int numberOfTasks = int.Parse(Console.ReadLine());
    //        var timesPerTasksString = Console.ReadLine().Split(' ');

    //        int[] timesPerTasks = new int[numberOfTasks];
    //        for (int i = 0; i < numberOfTasks; i++)
    //        {
    //            timesPerTasks[i] = int.Parse(timesPerTasksString[i]);
    //        }

    //        string[] dependencies = new string[numberOfTasks];
    //        bool noDependencies = true;
    //        List<int> tasksWithoutDependencies = new List<int>();
    //        List<int> tasksWithDependencies = new List<int>();
    //        for (int i = 0; i < numberOfTasks; i++)
    //        {
    //            dependencies[i] = Console.ReadLine();
    //            if (dependencies[i] != "0")
    //            {
    //                tasksWithDependencies.Add(timesPerTasks[i]);
    //                noDependencies = false;
    //            }
    //            else
    //            {
    //                tasksWithoutDependencies.Add(timesPerTasks[i]);
    //            }
    //        }
    //        var result = LCM(tasksWithoutDependencies.ToArray());
    //        if (!noDependencies)
    //        {
    //            result += tasksWithDependencies.Sum();
    //        }
    //        if (tasksWithoutDependencies.Count() == 0)
    //        {
    //            result =  -1;
    //        }


    //        Console.WriteLine(result);
    //    }


    //    // http://stackoverflow.com/questions/3635564/greatest-common-divisor-from-a-set-of-more-than-2-integers
    //    private static int GCD(int a, int b)
    //    {
    //        if (b == 0)
    //        {
    //            return a;
    //        }

    //        return GCD(b, a % b);
    //    }

    //    private static long LCM(params int[] numbers)
    //    {
    //        if (numbers.Length == 1)
    //        {
    //            return numbers[0];
    //        }
    //        else if (numbers.Length == 0)
    //        {
    //            return 0;
    //        }
    //        long lcm = 0;
    //        int a = numbers[0];
    //        for (int i = 1; i < numbers.Length; i++)
    //        {
    //            lcm = (a * numbers[i])/(GCD(a, numbers[i]));
    //            a = numbers[i];
    //        }

    //        return lcm;
    //    }
    //}

    public class Program
    {
        public static void Main()
        {
            int numberOfTasks = int.Parse(Console.ReadLine());
            var timesPerTasksString = Console.ReadLine().Split(' ');

            Dictionary<int, List<int>> timesPerTasks = new Dictionary<int, List<int>>();

            for (int i = 0; i < numberOfTasks; i++)
            {
                var currentDependencies = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Array.Sort(currentDependencies);
                var curredep = currentDependencies.ToList();
                timesPerTasks.Add(int.Parse(timesPerTasksString[i]), curredep);

            }
            string[] dependencies = new string[numberOfTasks];
            bool noDependencies = true;
            List<int> tasksWithoutDependencies = new List<int>();
            List<int> tasksWithDependencies = new List<int>();
            foreach (var item in timesPerTasks)
            {
                if (item.Value[0] == 0)
                {
                    tasksWithoutDependencies.Add(item.Key);
                }

                else
                {
                    tasksWithDependencies.Add(item.Key);
                }
            }
            var result = LCM(tasksWithoutDependencies.ToArray());
            if (!noDependencies)
            {
                result += tasksWithDependencies.Sum();
            }

            if (tasksWithoutDependencies.Count() == 0)
            {
                result = -1;
            }


            Console.WriteLine(result);
        }


        // http://stackoverflow.com/questions/3635564/greatest-common-divisor-from-a-set-of-more-than-2-integers
        private static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return GCD(b, a % b);
        }

        private static long LCM(params int[] numbers)
        {
            if (numbers.Length == 1)
            {
                return numbers[0];
            }
            else if (numbers.Length == 0)
            {
                return 0;
            }
            long lcm = 0;
            int a = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                lcm = (a * numbers[i]) / (GCD(a, numbers[i]));
                a = numbers[i];
            }

            return lcm;
        }
    }
}
