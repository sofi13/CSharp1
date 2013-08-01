/*Write a boolean expression that returns if the bit at position p (counting from 0)
  in a given integer number v has value of 1. Example: v=5; p=1  false.
*/

using System;

class ReturnsIfTheBitAtPosition
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int mask = 1 << p;
        int result = mask & number;
        result = result >> p;

        Console.WriteLine(result);

        if (result == 1)
        {
            Console.WriteLine(true);
        }
        else if (result == 0)
        {
            Console.WriteLine(false);
            return;
        }       
    }
}

