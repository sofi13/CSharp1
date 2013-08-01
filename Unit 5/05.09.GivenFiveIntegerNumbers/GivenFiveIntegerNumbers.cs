/*We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0.
  Example: 3, -2, 1, 1, 8  1+1-2=0.
*/

using System;

class GivenFiveIntegerNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int numOne = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        int numTwo = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        int numThree = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fourth number:");
        int numFour = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter fifth number:");
        int numFive = int.Parse(Console.ReadLine());

        if (numOne + numTwo + numThree == 0 | numOne + numThree + numFour == 0 | numOne + numFour + numFive ==0)
        {
            Console.WriteLine("The sum of some subset is 0.");
        }
        else if (numOne + numTwo + numFour == 0 | numOne + numTwo + numFive == 0 | numOne + numThree + numFive ==0)
        {
            Console.WriteLine("The sum of some subset is 0.");
        }
        else if (numTwo + numThree + numFour == 0 | numTwo + numThree + numFive == 0 | numOne + numFour + numFive == 0)
        {
            Console.WriteLine("The sum of some subset is 0.");
        }
        else
        {
            Console.WriteLine("The sum is not 0.");
        }
    }
}

