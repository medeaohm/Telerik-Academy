namespace Passwords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;
    using System.Threading.Tasks;

    //public class Program
    //{
    //    //const char Left = '<';
    //    //const char Same = '=';
    //    //const char Right = '>';
    //    //const string AllowedCharachers = "1234567890";

    //    //public static void Main()
    //    //{
    //    //    int n = int.Parse(Console.ReadLine());
    //    //    string directions = Console.ReadLine();
    //    //    int k = int.Parse(Console.ReadLine());

    //    //    //int n = 3;
    //    //    //string directions = "<<";
    //    //    //int k = 1;


    //    //    var possibilities = new SortedSet<string>();
    //    //    for (int i = 1; i <= n; i++)
    //    //    {
    //    //        StringBuilder currentPassword = new StringBuilder();

    //    //        var currentIndex = i;
    //    //        currentPassword.Append(AllowedCharachers[currentIndex - 1]);
    //    //        var currentDirection = directions[currentPassword.Length - 1];
    //    //        var currenjhdakfd = currentPassword.ToString();

    //    //        if (currentDirection == Left)
    //    //        {
    //    //            currentIndex--;
    //    //        }
    //    //        else if (currentDirection == Right)
    //    //        {
    //    //            currentIndex--;
    //    //        }
    //    //        while (currentIndex >= 0 && currentIndex < AllowedCharachers.Length)
    //    //        {
    //    //            switch (currentDirection)
    //    //            {
    //    //                case Left:
    //    //                    currentIndex--;
    //    //                    break;
    //    //                case Right:
    //    //                    currentIndex++;
    //    //                    break;
    //    //                case Same:
    //    //                    break;
    //    //                default:
    //    //                    break;

    //    //            }

    //    //            if (currentIndex < 0 || currentIndex >= AllowedCharachers.Length)
    //    //            {
    //    //                break;
    //    //            }

    //    //            currentPassword.Append(AllowedCharachers[currentIndex]);
    //    //            var currenfd = currentPassword.ToString();
    //    //            if (currentPassword.ToString().Length == n)
    //    //            {
    //    //                possibilities.Add(currentPassword.ToString());
    //    //                break;
    //    //            }
    //    //        }                

    //    //        if (currentPassword.ToString().Length == n)
    //    //        {
    //    //            possibilities.Add(currentPassword.ToString());
    //    //        }

    //    //    }

    //    //    Console.WriteLine(possibilities.ElementAt(k-1));
    //    //}
    //}

    public class Program
    {
        const char Left = '<';
        const char Same = '=';
        const char Right = '>';
        const string AllowedCharachers = "1234567890";

        static string[] array;
        static SortedSet<int> sSet = new SortedSet<int>();

        public static void Main()
        {
            //int n = int.Parse(Console.ReadLine());
            //string directions = Console.ReadLine();
            //int k = int.Parse(Console.ReadLine());

            int n = 10;
            string directions = ">>>>>>>>>";
            int k = 1;

            array = new string[n];
            Combinations(array, directions, 1, 1, n);
            Console.WriteLine(sSet.ElementAt(k - 1));

        }

        private static void Combinations(string[] array, string directions, int index, int start, int n)
        {
            if (index >= n)
            {
                sSet.Add(int.Parse(String.Join("", array)));
                return;
            }

            array[0] = AllowedCharachers[index - 1].ToString();
            for (int i = start; i <= n ; i++)
            {
                if (directions[i - 1] == Right)
                {
                    array[index] = AllowedCharachers[i].ToString();
                }
                else if (directions[i - 1] == Left)
                {
                    array[index] = AllowedCharachers[i-1].ToString();
                }
                else
                {
                    array[index] = AllowedCharachers[i].ToString();
                }
                Combinations(array, directions, index + 1, i + 1, n);
            }
        }
    }
}
