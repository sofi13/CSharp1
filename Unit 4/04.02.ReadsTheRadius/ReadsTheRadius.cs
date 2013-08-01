/*Write a program that reads the radius r of a circle and prints its perimeter and area.
*/

using System;

class ReadsTheRadius
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of a circle:");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("The perimeter is {0:0.00} and the area is {1:0.00}", perimeter, area);
    }
}

