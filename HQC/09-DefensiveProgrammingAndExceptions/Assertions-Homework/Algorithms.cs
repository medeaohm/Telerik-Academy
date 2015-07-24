namespace Assertions_Homework
{
    using System;
    using System.Diagnostics;

    public class Algorithms
    {
        public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array should not be null");
            Debug.Assert(arr.Length > 0, "Array should not be empty!");

            for (int index = 0; index < arr.Length - 1; index++)
            {
                int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
                Swap(ref arr[index], ref arr[minElementIndex]);
            }
        }

        public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array should not be null.");
            Debug.Assert(value != null, "Value should not be null.");

            return BinarySearch(arr, value, 0, arr.Length - 1);
        }

        private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array should not be null!");
            Debug.Assert(arr.Length > 0, "Array should not be empty");
            Debug.Assert(startIndex != null, "Start Index should not be null!");
            Debug.Assert(endIndex != null, "End Index should not be null!");
            Debug.Assert(startIndex >= 0, "Start Index should be > 0!");
            Debug.Assert(endIndex >= 0, "End Index should be > 0!");
            Debug.Assert(startIndex < arr.Length - 1, "Start Index should be <= array length!");
            Debug.Assert(endIndex < arr.Length - 1, "End Index should be <= array length!");
            Debug.Assert(endIndex >= startIndex, "End Index should be >= Start Index!");

            int minElementIndex = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (arr[i].CompareTo(arr[minElementIndex]) < 0)
                {
                    minElementIndex = i;
                }
            }

            return minElementIndex;
        }

        private static void Swap<T>(ref T x, ref T y)
        {
            T oldX = x;
            x = y;
            y = oldX;
        }

        private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
            where T : IComparable<T>
        {
            Debug.Assert(arr != null, "Array should not be null!");
            Debug.Assert(arr.Length > 0, "Array should not be empty");
            Debug.Assert(value != null, "Value is null.");
            Debug.Assert(startIndex != null, "Start Index should not be null!");
            Debug.Assert(endIndex != null, "End Index should not be null!");
            Debug.Assert(startIndex >= 0, "Start Index should be > 0!");
            Debug.Assert(endIndex >= 0, "End Index should be > 0!");
            Debug.Assert(startIndex < arr.Length - 1, "Start Index should be <= array length!");
            Debug.Assert(endIndex < arr.Length - 1, "End Index should be <= array length!");
            Debug.Assert(endIndex >= startIndex, "End Index should be >= Start Index!");

            while (startIndex <= endIndex)
            {
                int midIndex = (startIndex + endIndex) / 2;
                if (arr[midIndex].Equals(value))
                {
                    return midIndex;
                }

                if (arr[midIndex].CompareTo(value) < 0)
                {
                    // Search on the right half
                    startIndex = midIndex + 1;
                }
                else
                {
                    // Search on the right half
                    endIndex = midIndex - 1;
                }
            }

            // Searched value not found
            return -1;
        }
    }
}
