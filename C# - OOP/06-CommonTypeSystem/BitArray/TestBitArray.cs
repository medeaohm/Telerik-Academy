namespace BitArray
{
    using System;

    public class TestBitArray
    {
        public static void Main()
        {
            BitArray64 arr = new BitArray64(20u);
            BitArray64 arr2 = new BitArray64(300u);

            Console.WriteLine("Bit Array 1: {0}", arr);
            arr[1] = 0;
            Console.WriteLine("Bit Array 2: {0}", arr2);

            Console.WriteLine("Is BitArray1 == BitArray2? -> {0}", arr == arr2);
            Console.WriteLine("Is BitArray1 equal to BitArray1? -> {0}", arr.Equals(arr));
            Console.WriteLine("Is BitArray1 != BitArray2? -> {0}", arr != arr2);
        }
    }
}
