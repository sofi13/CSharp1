/*Write a program to calculate the Nth Catalan number by given N.
*/

using System;

class CatalanNumberByGivenN
{
    static void Main()
    {
        Console.WriteLine("Enter number N:");
        long numberN = long.Parse(Console.ReadLine());
        double number = 1;

        for (int i = 2; i <= numberN; i++)
        {
            number *= (4 * i - 2) / (1.0 + i);
        }

        Console.WriteLine("The Nth Catalan number is: {0}", number);
    }
}

