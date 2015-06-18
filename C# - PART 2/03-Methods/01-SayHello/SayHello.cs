//### Problem 1. Say Hello
//*	Write a method that asks the user for his name and prints `�Hello, <name>�`
//*	Write a program to test this method.

//_Example:_

//| input |     output    |
//|:-----:|:-------------:|
//| Peter | Hello, Peter! |

using System;

class SayHello
{
    static void Main()
    {
        Console.Write("Please insert you name: ");
        string name = Console.ReadLine();
        Hello(name);
    }

    private static void Hello(string name)
    {
        Console.WriteLine("Hello {0}!", name); ;
    }
}

