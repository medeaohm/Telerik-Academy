namespace StringAndGreedy
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            int n = input.Length;
            input = input + input;

            int[] fl = new int[n + 1];
            fl[0] = -1;
            fl[1] = 0;

            for (int i = 1; i < n; i++)
            {
                int j = fl[i];

                while (j >= 0 && input[i] != input[j])
                {
                    j = fl[j];
                }

                fl[i + 1] = j + 1;
            }

            int matched = 0;
            for (int i = 1; i < input.Length; i++)
            {
                while (matched >= 0 && input[i] != input[matched])
                {
                    matched = fl[matched];
                }

                matched++;

                if (matched == n)
                {
                    Console.WriteLine(input.Substring(0, i - (n - 1)));
                }
            }
        }
    }
}
