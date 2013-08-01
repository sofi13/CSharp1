/*Write a program that gets a number n and after that gets more n numbers 
 and calculates and prints their sum. 
*/

using System;

class GetsANumberN
{
    static void Main()
    {
        Console.WriteLine("Enter number n:");
        int numberN = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 0; i < numberN; i++)
        {
            Console.WriteLine("Enter new number:");
            int newNum = int.Parse(Console.ReadLine());
            sum = sum + newNum;
        }
        Console.WriteLine("The sum is: {0}", sum);
    }
}

