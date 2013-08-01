/*Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.
 */ 

using System;

class DeclareABooleanVariable
{
    static void Main()
    {
        bool isFemale;
        Console.Write("What is your gender (m/f):");
        string myGender = Console.ReadLine();

        if (myGender == "f")
        {
            isFemale = true;
            Console.WriteLine("You are female: {0}", isFemale);
        }
        else if (myGender == "m")
        {
            isFemale = false;
            Console.WriteLine("You are female: {0}", isFemale);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }

    }
}

