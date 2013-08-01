/*Write a program that enters the coefficients a, b and c of a quadratic equation
a*x2 + b*x + c = 0
and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.
*/

using System;

class EntersTheCoefficients 
{
    static void Main()
    {
        Console.WriteLine("Ente a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Ente b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Ente c:");
        double c = double.Parse(Console.ReadLine());
        double d = (b * b) - (4 * a * c);

        if (d < 0)
        {
            Console.WriteLine("Equation does not have real roots");
        }
        else if (d == 0)
        {
            double x = (-1 * b) / (2 * a);
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            double x1 = ((-1 * b) + Math.Sqrt(d)) / (2 * a);
            double x2 = ((-1 * b) - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("x1 = {0}", x1);
            Console.WriteLine("x2= {0}", x2);
        }
    }
}

