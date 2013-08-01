/*Write a program that safely compares floating-point numbers with precision of 0.000001. 
  Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
 */ 

using System;

class FloatingPointNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        float firstFloat = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        float secondFloat = float.Parse(Console.ReadLine());

        bool compare = firstFloat == secondFloat;
        Console.WriteLine("Compare:"+ compare);
    }
}

