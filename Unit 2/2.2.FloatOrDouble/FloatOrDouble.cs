/*Which of the following values can be assigned to a variable of type 
  float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 */ 

using System;

class FloatOrDouble
{
    static void Main()
    {
        double doubleNumOne = 34.567839023;
        float floatNumOne = 12.345F;
        double doubleNumTwo = 8923.1234857;
        float floatNumTwo = 3456.091F;

        Console.WriteLine("Float type values are: {0} and {1}", floatNumOne, floatNumTwo);
        Console.WriteLine("Double type values are: {0} and {1}", doubleNumOne, doubleNumTwo);
    }
}

