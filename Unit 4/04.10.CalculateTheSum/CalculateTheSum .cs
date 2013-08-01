/*Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...
*/

using System;

class CalculateTheSum 
{
    static void Main()
    {
        double sum = 1;
        int a = 1;
        for (double i = 2; 1/i >= 0.001; i++)
        {
            sum = sum + 1 / (i * a);
            a = a * (-1);
        }
        Console.WriteLine("The sum is: {0:0.000}", sum);
    }
}

