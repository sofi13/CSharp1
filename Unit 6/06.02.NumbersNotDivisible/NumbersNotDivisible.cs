/*Write a program that prints all the numbers from 1 to N, that are not divisible 
 by 3 and 7 at the same time.
*/

using System;

class NumbersNotDivisible
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 21 != 0)
            {
                Console.WriteLine(i);
                counter++;
            }
        }
        Console.WriteLine("The number of numbers are: {0}", counter);
    }
}

