/*Write an expression that checks if given integer is odd or even.
*/

using System;

class ChecksOddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        if (number % 2 == 0)
        {
            Console.WriteLine("Your number is even.");
        }
        else
        {
            Console.WriteLine("Your number is odd.");
        }
    }
}

