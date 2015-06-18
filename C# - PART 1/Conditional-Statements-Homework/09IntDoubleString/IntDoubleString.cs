using System;

//### Problem 9. Play with Int, Double and String
//*	Write a program that, depending on the user’s choice, inputs an `int`, `double` or `string` variable.
//    *	If the variable is `int` or `double`, the program increases it by one.
//    *	If the variable is a `string`, the program appends `*` at the end.
//*	Print the result at the console. Use switch statement.

//_Example 1:_                                                

//| program                | user  |
//|------------------------|-------|
//| Please choose a type:  |       |
//| 1 --> int              |       |
//| 2 --> double           | 3     |
//| 3 --> string           |       |
//|                        |       |
//| Please enter a string: | hello |
//|                        |       |
//| hello*                 |       |



class IntDoubleString
    {
        static void Main()
        {
            Console.WriteLine("Please choose a type: \n\t 1 --> int \n\t 2 --> double \n\t 3 --> string");
            int choice;
            bool valid = int.TryParse(Console.ReadLine(), out choice);

            if (! valid)
            {
                Console.WriteLine("Invalid choice...");
            }
            else
            switch (choice)
            {
                case 1: Console.WriteLine("Please insert a integer number...");
                    int intNum = int.Parse(Console.ReadLine());
                    Console.WriteLine(intNum + 1);  break;
                case 2: Console.WriteLine("Please insert a floating-point number...");
                    double doubleNum = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleNum + 1); break;
                case 3: Console.WriteLine("Please insert a string...");
                    string str = Console.ReadLine();
                    Console.WriteLine(str + "*"); break;
                default: Console.WriteLine("Invalid choice..");
                    break;
            }
        }
    }

