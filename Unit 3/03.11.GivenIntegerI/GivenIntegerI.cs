/*Write an expression that extracts from a given integer i the value of a given bit number b. 
  Example: i=5; b=2  value=1.
*/

using System;

class GivenIntegerI
{
    static void Main()
    {
        int i = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int result = i & mask;
        int bit = result >> b;

        Console.WriteLine("The bit on integer: {0} of position: {1} has a value of: {2}.", i, b, bit);
    }
}

