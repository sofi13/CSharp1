/*Write an if statement that examines two integer variables and exchanges their values
 if the first one is greater than the second one.
*/

using System;

class IfStatement
{
    static void Main()
    {
        Console.Write("Enter value one:");
        int numberOne = int.Parse(Console.ReadLine());
        Console.Write("Enter value two:");
        int numberTwo = int.Parse(Console.ReadLine());
        int numberThree;

        if (numberOne > numberTwo)
        {
            numberThree = numberOne;
            numberOne = numberTwo;
            numberTwo = numberThree;

            Console.WriteLine("Exchanges values are: {0}, {1}", numberOne, numberTwo);
        }
        else
        {
            Console.WriteLine("The values can not be changes!");
        }
    }
}

