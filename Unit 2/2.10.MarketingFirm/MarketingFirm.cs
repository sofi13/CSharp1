/*A marketing firm wants to keep record of its employees. 
  Each record would have the following characteristics – 
  first name, family name, age, gender (m or f), ID number, 
  unique employee number (27560000 to 27569999). 
  Declare the variables needed to keep the information 
  for a single employee using appropriate data types and descriptive names.
 */

using System;

class MarketingFirm
{
    static void Main()
    {
        string firstName = "Dimitar";
        string familyName = "Dimitrov";
        byte age = 20;
        char gender = 'm';
        uint idNum = 123456789;
        int empNum = 27560000;

        Console.WriteLine("Name: {0} {1}\nAge: {2}\nGender: {3}\nID number: {4}\nUnique employee number: {5}", firstName, familyName, age, gender, idNum, empNum);

    }
}

