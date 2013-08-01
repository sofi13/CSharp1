/*Write a program that finds the greatest of given 5 variables.
*/

using System;

class FindsTheGreatest
{
    static void Main()
    {
        double greater = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter number:");
            double number = double.Parse(Console.ReadLine());

            if (i == 0)
            {
                greater = number;
            }
            else
            {
                if (greater < number)
                {
                    greater = number;
                }
            }
        }
        Console.WriteLine("The greatest number of elements is: {0}.", greater);
    }
}

