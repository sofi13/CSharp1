/*Write a program that shows the sign (+ or -) of the product of three real
 numbers without calculating it. Use a sequence of if statements.
*/

using System;

class ShowsTheSign 
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number:");
        double thirdNum = double.Parse(Console.ReadLine());

        if ((firstNum < 0 && secondNum < 0 && thirdNum < 0)||(firstNum < 0 && secondNum > 0 && thirdNum > 0)||(firstNum > 0 && secondNum < 0 && thirdNum > 0)||(firstNum > 0 && secondNum > 0 && thirdNum < 0))
        {
            Console.WriteLine("The sign is (-).");
        }

        else if ((firstNum < 0 && secondNum < 0 && thirdNum > 0) || (firstNum < 0 && secondNum > 0 && thirdNum < 0) || (firstNum > 0 && secondNum < 0 && thirdNum < 0))
        {
            Console.WriteLine("The sign is (+).");
        }
        else if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        {
            Console.WriteLine("The product of three numbers is 0.");
        }
        else if (firstNum > 0 && secondNum > 0 && thirdNum > 0)
        {
            Console.WriteLine("The sign is (+).");
        }

    }
}
