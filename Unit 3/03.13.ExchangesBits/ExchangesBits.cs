/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
*/

using System;

class ExchangesBits
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        uint startNumber;
        bool errorDetect = uint.TryParse(Console.ReadLine(), out startNumber);
        while (errorDetect == false)
        {
            Console.Write("You've entered an invalid number. Try again - ");
            errorDetect = uint.TryParse(Console.ReadLine(), out startNumber);
        }
        uint number = startNumber;
        uint newNumber = 0;
        uint bitTempValue;
        uint mask = (uint)7 << 3;
        uint numberAndMask = number & mask;
        uint bitIValue = numberAndMask >> 3;
        mask = (uint)7 << 24;
        numberAndMask = number & mask;
        uint bitI2Value = numberAndMask >> 24;
        bitTempValue = bitI2Value;
        if (bitIValue == 0)
        {
            mask = unchecked((uint)~(7 << 24));
            newNumber = number & mask;
        }
        else
        {
            mask = (uint)7 << 24;
            newNumber = number | mask;
        }
        number = newNumber;
        if (bitTempValue == 0)
        {
            mask = unchecked((uint)~(7 << 3));
            newNumber = number & mask;
        }

        else
        {
            mask = (uint)7 << 3;
            newNumber = number | mask;
        }
        number = newNumber;

        Console.WriteLine("\nNumber: \t{0}\nIn bits:\t{1}", startNumber, Convert.ToString(startNumber, 2).PadLeft(32, '0'));
        Console.WriteLine("New number:\t{0}\nIn bits:\t{1}\n", number, Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}

