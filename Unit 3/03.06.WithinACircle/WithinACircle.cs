/*Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
*/

using System;

class WithinACircle
{
    static void Main()
    {
        Console.WriteLine("Enter x:");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:");
        decimal y = decimal.Parse(Console.ReadLine());
        decimal radius = 5;

        if ((x * x + y * y) <= radius * radius)
        {
            Console.WriteLine("Points {0} and {1} is within a circle K(O, 5).", x, y);
        }
        else
        {
            Console.WriteLine("Points {0} and {1} is out of a circle K(O, 5).", x, y);
        }
    }
}

