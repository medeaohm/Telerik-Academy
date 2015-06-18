using System;

//### Problem 5.	Boolean Variable
//*	Declare a Boolean variable called `isFemale` and assign an appropriate value corresponding to your gender.
//*	Print it on the console.

    class BooleanVar
    {
        static void Main()
        {
            char gender = 'f';
            bool isFemale = (gender == 'f');
            Console.WriteLine("My gender is: " + gender);
            Console.WriteLine("Is it true that I am female? \n" + isFemale);
        }
    }

