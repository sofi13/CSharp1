﻿/*Write a program to print the first 100 members of the sequence of Fibonacci:
 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
*/

using System;

class TheSequenceOfFibonacci
{
    static void Main()
    {
        decimal numberOne = 0M;
        decimal numberTwo = 1M;
        decimal sum;

        for (byte i = 0; i < 100; i++)
        {
            Console.WriteLine(numberOne);
            sum = numberOne + numberTwo;
            numberOne = numberTwo;
            numberTwo = sum;
        }
    }
}

