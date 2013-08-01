/*Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
*/

using System;

class CalculatesNumbersTwo
{
    static void Main()
    {
        Console.WriteLine("Enter number for N:");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number for K:");
        int numberK = int.Parse(Console.ReadLine());

        int factorialN = 1;
        int factorialK = 1;
        int sum = 1;

        if (1 < numberN && 1 < numberK && numberN < numberK)
        {
            for (int i = numberN; i > 0; i--)
            {
                factorialN *= i;
            }

            for (int j = numberK; j > 0; j--)
            {
                factorialK *= j;
            }

            for (int s = (numberK - numberN); s > 0; s--)
            {
                sum *= s;
            }

            int result = (factorialN * factorialK) / sum;

            Console.WriteLine("N!:{0}, K!:{1} calculation of N!*K! / (K-N)! is: {2}", factorialN, factorialK, result);
        }

        else
        {
            Console.WriteLine("Number K must be bigger than number N!");
        }
    }
}

