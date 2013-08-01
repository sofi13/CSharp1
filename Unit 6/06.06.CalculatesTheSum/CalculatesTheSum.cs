/*Write a program that, for a given two integer numbers N and X, calculates the 
 sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
*/

using System;

class CalculatesTheSum
{
    static void Main()
    {
        Console.WriteLine("Enter number N:");
        int numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number X:");
        int numberX = int.Parse(Console.ReadLine());

        decimal factorialN = 1;
        decimal factorialX = 1;
        decimal sumS = 0;

        for (int i = 1; i < numberN; i++)
        {
            factorialN *= i;
            factorialX *= numberX;
            sumS += (factorialN / factorialX);
        }
       Console.WriteLine(1 + sumS); 
    }
}

