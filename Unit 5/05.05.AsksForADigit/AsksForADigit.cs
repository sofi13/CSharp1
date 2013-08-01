/*Write program that asks for a digit and depending on the input shows the name 
  of that digit (in English) using a switch statement.
*/

using System;

class AsksForADigit
{
    static void Main()
    {
        Console.WriteLine("Enter number:");
        byte numberN = byte.Parse(Console.ReadLine());
        string number;

        switch (numberN)
        {
            case 0: number = "Zero"; break;
            case 1: number = "One"; break;
            case 2: number = "Two"; break;
            case 3: number = "Three"; break;
            case 4: number = "Four"; break;
            case 5: number = "Five"; break;
            case 6: number = "Six"; break;
            case 7: number = "Seven"; break;
            case 8: number = "Eight"; break;
            case 9: number = "Nine"; break;
            default: number = "Incorrect input!"; break;
        }
        Console.WriteLine("The number you have enter is: {0}", number);
    }
}

