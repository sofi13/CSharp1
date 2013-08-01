/*Write a program that reads from the console a positive integer number N (N < 20) 
 and outputs a matrix like the following:
	N = 3			N = 4
*/

using System;

class PositiveIntegerNumber 
{
    static void Main()
    {
        Console.WriteLine("Enter number N:");
        int numberN = int.Parse(Console.ReadLine());

        if (numberN < 20)
        {
            int number;

            for (int column = 1; column <= numberN; column++)
            {
                number = column;

                for (int row = 1; row <= numberN; row++)
                {
 
                    Console.Write(number);
                    number++;
                }
 
                Console.WriteLine();
            }
        }

        else
        {
            Console.WriteLine("Enter number smaller than 20!");
        }
    }
}

