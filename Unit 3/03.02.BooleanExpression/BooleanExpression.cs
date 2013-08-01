/*Write a boolean expression that checks for given integer if it can be
  divided (without remainder) by 7 and 5 in the same time.
*/

using System;

class BooleanExpression
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        bool divideBy5 = number % 5 == 0;
        bool divideBy7 = number % 7 == 0;
        bool divide = divideBy5 && divideBy7;
        Console.WriteLine(divide);
    }
}

