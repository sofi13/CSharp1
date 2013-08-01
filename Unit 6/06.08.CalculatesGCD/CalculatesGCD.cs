/*Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
 Use the Euclidean algorithm (find it in Internet).
*/

using System;

class CalculatesGCD
{
    static void Main()
    {
        Console.WriteLine("Enter number A:");
        double numberA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter number B:");
        double numberB = double.Parse(Console.ReadLine());

        if (numberA < numberB)
        {
            double temp = numberA;
            numberA = numberB;
            numberB = temp;
        }

        double result;
        double resultRemainder;

        Console.WriteLine();

        while (true)
        {
            result = numberA / numberB;
            resultRemainder = numberA % numberB;
            if (resultRemainder != 0)
            {
                Console.WriteLine("{0} : {1} = {2} ; reminder = {3}", numberA, numberB, result, resultRemainder);
                numberA = numberB;
                numberB = resultRemainder;
            }
            else
            {
                Console.WriteLine("The greatest common divider is: {0}", numberB);
                break;
            } 
        }
    }
}

