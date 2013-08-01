/*Write a program that reads two positive integer numbers and prints how many
  numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). 
  Example: p(17,25) = 2.
*/

using System;

class TwoPositiveInteger 
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int numberTwo = int.Parse(Console.ReadLine());
        int p = 0;

        for (int i = numberOne; i <= numberTwo; i++)
        {
            if (i % 5 == 0)
            {
                p = p + 1;
            }
        }
        Console.WriteLine("Number P ({0},{1})={2}", numberOne, numberTwo, p);
    }
}

