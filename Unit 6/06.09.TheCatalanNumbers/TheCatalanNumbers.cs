/*In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
(2*n)! / (n + 1)! * n!
 */

using System;

class TheCatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N:");
        double numN = double.Parse(Console.ReadLine());

        double plusOne = numN + 1;
        double poTwo = numN * 2;
        double result = 1;
        double plusResult = 1;
        double poResult = 1;

        for (int i = 1; i <= numN; i++)
        {
            result *= i;
        }

        for (int i = 1; i <= plusOne; i++)
        {
            plusResult *= i;
        }

        for (int i = 1; i <= poTwo; i++)
        {
            poResult *= i;
        }

        double resul = poResult / (plusResult * result);
        Console.WriteLine("Catalan number is: {0}", resul);
    }
}

