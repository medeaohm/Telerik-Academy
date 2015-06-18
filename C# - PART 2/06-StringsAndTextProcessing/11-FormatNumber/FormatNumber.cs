/*Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.*/

using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Decimal format = {0,15}", number);
        Console.WriteLine("Hexadecimal format = {0,15:X}", number);
        Console.WriteLine("Percentage = {0,15:P}", number / 100.0);
        Console.WriteLine("Scientific Notation = {0,15:E}", number);
    }
}