//### Problem 4. Triangle surface
//*	Write methods that calculate the surface of a triangle by given:
//    *	Side and an altitude to it;
//    *	Three sides;
//    *	Two sides and an angle between them;
//*	Use `System.Math`.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Calculating area of triangle. Please choose an option from the menu above:\n");
        Console.WriteLine("1 --> for calculating by side and altitude!");
        Console.WriteLine("2 --> for calculating by 3 sides!");
        Console.WriteLine("3 --> for calculating by 2 sides and an angle between them!\n");
        Console.Write("Please enter a number [1 to 3]: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": SideAndAltitude(); break;
            case "2": ThreeSides();      break;
            case "3": TwoSidesAndAngle(); break;
            default: Console.WriteLine("Invalid input");                break;
        }
    }

    private static void SideAndAltitude()
    {
        Console.Write("\nPlease insert the side = ");
        int side = int.Parse(Console.ReadLine());
        Console.Write("Please insert the altitude = ");
        int altitude = int.Parse(Console.ReadLine());

        double area = (side * altitude) / 2;
        if (area == 0)
        {
            Console.WriteLine("\nInpossible! Such a triangle does not exist!");
        }
        else
        {
            Console.WriteLine("\nThe area of a triangle with side {0} and altitude {1} is {2:0.00}", side, altitude, area);
        }
    }

    private static void ThreeSides()
    {
        Console.Write("\nPlease insert the first side = ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Please insert the second side = ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Please insert the third side = ");
        double side3 = double.Parse(Console.ReadLine());

        double p = (side1 + side2 + side3) / 2;
        double area = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        if (area == 0)
        {
            Console.WriteLine("\nInpossible! Such a triangle does not exist!");
        }
        else
        {
            Console.WriteLine("\nThe area of a triangle with side1 = {0}, side2 = {1} and side3 = {2} is {3:0.00}", side1, side2, side3, area); 
        }
    }

    private static void TwoSidesAndAngle()
    {
        Console.Write("\nPlease insert the first side = ");
        int side1 = int.Parse(Console.ReadLine());
        Console.Write("Please insert the second side = ");
        int side2 = int.Parse(Console.ReadLine());
        Console.Write("Please insert the angle between them (in degrees) = ");
        int angle = int.Parse(Console.ReadLine());

        double angleR = (angle * Math.PI) / 180;
        double area = (side1 * side2 * Math.Sin(angleR))/2;
        if (area == 0)
        {
            Console.WriteLine("\nInpossible! Such a triangle does not exist!");
        }
        else
        {
            Console.WriteLine("\nThe area of a triangle with side1 = {0}, side2 = {1} and angle = {2} is {3:0.00}", side1, side2, angle, area);
        }
    }
}

