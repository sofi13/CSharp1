/*Write an expression that calculates rectangle’s area by given width and height.
*/

using System;

class CalculatesRectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter rectangle's width:");
        string width = Console.ReadLine();
        double numberOne = double.Parse(width);

        Console.WriteLine("Enter rectangle's height:");
        string height = Console.ReadLine();
        double numberTwo = double.Parse(height);

        double numberThree = (numberOne * numberTwo);
        Console.WriteLine("Rectangle's area is:" + numberThree);
        
    }
}

