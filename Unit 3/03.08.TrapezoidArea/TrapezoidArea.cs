/*Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter side a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter side b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height h:");
        double h = double.Parse(Console.ReadLine());

        double trapezoidArea = ((a + b) / 2) * h;
        Console.WriteLine("TrapezoidArea's area is {0}", trapezoidArea);
    }
}

