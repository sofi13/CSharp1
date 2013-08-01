/*Create a program that assigns null values to an integer and to double variables. 
  Try to print them on the console, try to add some values or the null literal 
  to them and see the result.
 */ 

using System;

class NullValues
{
    static void Main()
    {
        int? firstNum = null;
        double? secondNum = null;
        Console.WriteLine("Int number is +> {0}\nDouble number is +> {1}", firstNum, secondNum);
        firstNum = firstNum + 5;
        secondNum = secondNum + null;
        Console.WriteLine("Int number is +> {0}\nDouble number is +> {1}", firstNum, secondNum);
    }
}

