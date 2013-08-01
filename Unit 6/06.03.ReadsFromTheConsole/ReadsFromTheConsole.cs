/*Write a program that reads from the console a sequence of N integer numbers 
 and returns the minimal and maximal of them.
*/

using System;

class ReadsFromTheConsole
{
    static void Main()
    {
        Console.WriteLine("Enter the count of numbers:");
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;

        for (int i = 1; i < n; i++)
        {
            Console.WriteLine("Enter a number:");
            int currentN = int.Parse(Console.ReadLine());
            if (currentN > max)
            {
                max = currentN;
            }
            else if (currentN < min)
            {
                min = currentN;
            }
        }
        Console.WriteLine("The minimal number is: {0}", min);
        Console.WriteLine("The maximal number is: {0}", max);
    }
}

