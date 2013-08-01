/*Sort 3 real values in descending order using nested if statements.
*/

using System;

class SortRealValues
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int numberThree = int.Parse(Console.ReadLine());

        if (numberOne > numberTwo && numberTwo > numberThree)
        {
            Console.WriteLine("The values are: {0},{1},{2}.", numberOne, numberTwo, numberThree);
        }
        else if (numberOne > numberThree && numberThree > numberTwo)
        {
            Console.WriteLine("The values are: {0},{1},{2}.", numberOne, numberThree, numberTwo);
        }
        else if (numberTwo > numberOne && numberOne > numberThree)
        {
            Console.WriteLine("The values are: {0},{1},{2}.", numberTwo, numberOne, numberThree);
        }
        else if (numberTwo > numberThree && numberThree > numberOne)
        {
            Console.WriteLine("The values are: {0},{1},{2}.", numberTwo, numberThree, numberOne);
        }
        else if (numberThree > numberOne && numberOne > numberTwo)
        {
            Console.WriteLine("The values are: {0},{1},{2}.", numberThree, numberOne, numberTwo);
        }
        else if (numberThree > numberTwo && numberTwo > numberOne)
        {
            Console.WriteLine("The values are: {0},{1},{2}.", numberThree, numberTwo, numberOne);
        }
    }
}

