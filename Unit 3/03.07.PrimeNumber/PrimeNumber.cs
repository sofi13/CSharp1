/*Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
  E.g. 37 is prime.
 */

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        
        bool isPrime = (number % 2 > 0) && (number % 3 > 0) && (number % 5 > 0) && (number % 7 > 0);
        bool isOneDigitNumber = (number == 2) || (number == 3) || (number == 5) || (number == 7);

        Console.WriteLine(isPrime || isOneDigitNumber);
    }
}

