/*Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} 
 of given 32-bit unsigned integer.
 */

using System;

class UnsignedInteger
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("Enter a p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter a q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter a k: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(n, 2));

        for (int i = 0; i <= k - 1; i++)
        {
            if ((n & (1 << p)) != (n & (1 << q)))
            {
                n = (uint)(n ^ (1 << p));
                n = (uint)(n ^ (1 << q));
            }
            p++;
            q++;
        }

        Console.WriteLine(Convert.ToString(n, 2));
    }
}

