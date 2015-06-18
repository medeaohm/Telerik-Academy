using System;

//### Problem 13.*	Comparing Floats
//*	Write a program that safely compares floating-point numbers (double) with precision `eps = 0.000001`.

//_Note: Two floating-point numbers `a` and `b` cannot be compared directly by `a == b` because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant `eps`._


class ComparingFloats
    {
        static void Main()
        {
            float a = 5.1f;
            float b = 5.8f;
            float diff = b - a;
            float eps = 0.000001f;
            bool equal = (diff < eps);
            Console.WriteLine("Is the difference between a and b less than {0}?  --> {1}", eps, equal);
        }
    }

