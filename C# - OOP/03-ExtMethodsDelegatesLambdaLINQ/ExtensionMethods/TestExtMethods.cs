namespace ExtensionMethods
{
    using System;
    using System.Text;
    using System.Collections.Generic;

    class TestExtMethods
    {
        public static void Main(string[] args)
        {
            TestSubstrStringBuilder();
            Console.WriteLine();
            TestIEnumerableExt();
        }

        static void TestIEnumerableExt()
        {
            Console.WriteLine("Test of the IEnumerable<T> extensions: ");
            IEnumerable<int> test = new List<int>() { 1, 2, 3, 4, 5 };
            var iEnum = new StringBuilder();
            foreach (var item in test)
            {
                iEnum.Append(item + " ");
            }
            Console.WriteLine("IEnumerable = {0}", iEnum.ToString());
            Console.WriteLine("Sum = {0}", test.IEnumerableSum());
            Console.WriteLine("Product = {0}", test.IEnumerableProduct());
            Console.WriteLine("Average = {0}", test.IEnumerableAverage());
            Console.WriteLine("Min = {0}", test.IEnumerableMin());
            Console.WriteLine("Max = {0}", test.IEnumerableMax());
        }

        static void TestSubstrStringBuilder()
        {
            Console.WriteLine("Test of the StringBuilder.Substring extension:");
            var testStr = new StringBuilder("Hello");
            var subStr = testStr.Substring(0, 3);
            var subStr2 = testStr.Substring(3);

            Console.WriteLine("Initial String: {0}", testStr.ToString());
            Console.WriteLine("Substring (startIndex = 0, count = 3): {0}", subStr.ToString());
            Console.WriteLine("Substring (startIndex = 3): {0}", subStr2.ToString());
        }
    }

    
}
