/*Write a program that gets two numbers from the console and prints the greater of them. 
 Don’t use if statements.
*/

using System;

class GetsTwoNumbers 
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int numberTwo = int.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0}", Math.Max(numberOne, numberTwo));
    }
}

