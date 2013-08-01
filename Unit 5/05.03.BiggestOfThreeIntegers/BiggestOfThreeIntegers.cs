/*Write a program that finds the biggest of three integers using nested if statements.
*/

using System;

class BiggestOfThreeIntegers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int numberOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int numberTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int numberThree = int.Parse(Console.ReadLine());

        if (numberOne > numberTwo)
        {
            if (numberOne > numberThree)
            {
                Console.WriteLine("The biggest number is:{0}", numberOne);
            }
            else
            {
                Console.WriteLine("The biggest number is:{0}", numberThree);
            }
        }
        else if (numberTwo > numberOne && numberTwo > numberThree)
        {
            Console.WriteLine("The biggest number is:{0}", numberTwo);
        }
        else
        {
            Console.WriteLine("The biggest number is:{0}", numberThree);
        }

    }
}

