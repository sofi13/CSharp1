/*Write a program that reads 3 integer numbers from the console and prints their sum.
*/

using System;

class ReadsIntegerNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int numberThree = int.Parse(Console.ReadLine());

        int sum = numberOne + numberTwo + numberThree;

        Console.WriteLine("The sum is:{0}", sum);
    }
}

