/*Declare an integer variable and assign it with the value 254 in hexadecimal format. 
  Use Windows Calculator to find its hexadecimal representation.
 */ 

using System;

class DeclareAnIntegerVariable
{
    static void Main()
    {
        int number = 0xFE;
        Console.WriteLine("{0:X} in hexadecimal is {0} in decimal.", number);
    }
}

