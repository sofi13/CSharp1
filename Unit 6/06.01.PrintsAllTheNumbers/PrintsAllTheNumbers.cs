/*Write a program that prints all the numbers from 1 to N.
*/

using System;

class PrintsAllTheNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("The numbers are:");

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

