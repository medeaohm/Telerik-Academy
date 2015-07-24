namespace Task3
{
    using System;

    public class Start
    {
        public static void Main()
        {
            int arrayLength = 100;
            int[] array = CreateArray(arrayLength);
            int expectedValue = 10;
            bool foundExpectedValue = false;

            for (int index = 0; index < arrayLength; index++)
            {
                Console.WriteLine(array[index]);

                if (array[index] == expectedValue)
                {
                    foundExpectedValue = true;
                    break;
                }
            }

            // More code here
            if (foundExpectedValue)
            {
                Console.WriteLine("Value Found");
            }
        }

        private static int[] CreateArray(int arrayLength)
        {
            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = i;
            }

            return array;
        }
    }
}
