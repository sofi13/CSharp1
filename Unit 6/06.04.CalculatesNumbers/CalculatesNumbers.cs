/*Write a program that calculates N!/K! for given N and K (1<K<N).
*/

using System;

class CalculatesNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter number for N:");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number for K:");
        int numberK = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int factorialK = 1;

        for (int i = numberN; i > 0; i--)
        {
            factorialN *= i;
        }

        for (int j = numberK; j > 0; j--)
        {
            factorialK *= j;
        }

        int result = factorialN / factorialK;

        Console.WriteLine("N!/K! = {0}", result);

    }
}

