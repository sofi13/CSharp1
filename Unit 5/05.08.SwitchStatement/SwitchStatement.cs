/*Write a program that, depending on the user's choice inputs int, double or string variable. 
 If the variable is integer or double, increases it with 1. 
 If the variable is string, appends "*" at its end. The program must show the value of 
 that variable as a console output. Use switch statement.
*/

using System;

class SwitchStatement
{
    static void Main()
    {
        Console.WriteLine("First enter 1 for int, 2 for double, and 3 for string. Next select value:");
        byte variable = byte.Parse(Console.ReadLine());

        switch (variable)
        {
            case 1: 
                int intVariable = int.Parse(Console.ReadLine());
                Console.WriteLine(intVariable + 1);
                break;
            case 2:
                double doubleVariable = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleVariable + 1); 
                break;
            case 3:
                string strVariable = Console.ReadLine();
                Console.WriteLine(strVariable + "*");
                break;
            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}

