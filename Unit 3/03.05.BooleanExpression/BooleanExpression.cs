/*Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
*/

using System;

class BooleanExpression
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());       
        int mask = 1 << 3;
        int nAndMask = number & mask;
        int bit = nAndMask >> 3;

        bool check;

        if (bit == 0)
        {
            check = true;
        }
        else
        {
            check = false;
        }
        if (check == true)
        {
            Console.WriteLine("The third bit is 0.");
        }
        else
        {
            Console.WriteLine("The third bit is 1.");
        }
    }
}

