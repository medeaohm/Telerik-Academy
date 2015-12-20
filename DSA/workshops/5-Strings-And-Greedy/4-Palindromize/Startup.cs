namespace Palindromize
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var answer = PalindromizeString(input);
            Console.WriteLine(answer);
        }

        private static bool isPalindrome(string input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
        private static string PalindromizeString(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                var firstIChars = input.Substring(0, i).ToCharArray();
                Array.Reverse(firstIChars);
                var candidate = input + new string(firstIChars);
                if (isPalindrome(candidate))
                {
                    return candidate;
                }
            }

            return string.Empty;
        }
    }
}
