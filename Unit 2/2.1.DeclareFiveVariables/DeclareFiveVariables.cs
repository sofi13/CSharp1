/*Declare five variables choosing for each of them the most 
  appropriate of the types byte, sbyte, short, ushort, int,
  uint, long, ulong to represent the following values: 52130,
  -115, 4825932, 97, -10000.
 */

using System;

class DeclareFiveVariables
{
    static void Main()
    {
        ushort ushortNum = 52130;
        sbyte sByteNum = -115;
        int intNum = 4825932;
        byte byteNum = 97;
        short shortNum = -10000;

        Console.WriteLine("{0}, {1}, {2}, {3}, {4}.", ushortNum, sByteNum, intNum, byteNum, shortNum);
    }
}

