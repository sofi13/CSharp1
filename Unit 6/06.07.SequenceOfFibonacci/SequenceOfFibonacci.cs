/*Write a program that reads a number N and calculates the sum of the first N 
members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.
*/

using System;

class SequenceOfFibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter number N:");
        int numberN = int.Parse(Console.ReadLine());

        long memberOne = 0;
        long memberTwo = 1;
        long sumMember;
        long sum = 0;

        if (numberN == 0 || numberN == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            for (int i = 1; i <= (numberN - 2); i++)
            {
            sumMember = memberOne + memberTwo;
            memberOne = memberTwo;
            memberTwo = sumMember;
            sum += sumMember;
            }
            Console.WriteLine("The sum is: {0}", (1+sum));
        }
    }
}

