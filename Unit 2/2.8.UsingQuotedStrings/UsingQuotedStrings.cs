/*Declare two string variables and assign them with following value:
The "use" of quotations causes difficulties.
 * Do the above in two different ways: with and without using quoted strings.
 */

using System;

class UsingQuotedStrings
{
    static void Main()
    {
        string firstVar = "The \"use\" of quotations causes difficulties.";
        string secondVar = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("Without quoted: {0}\nWith quoted: {1}", firstVar, secondVar);

    }
}

