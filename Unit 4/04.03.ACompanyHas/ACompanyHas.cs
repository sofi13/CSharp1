/*A company has name, address, phone number, fax number, web site and manager. 
  The manager has first name, last name, age and a phone number. 
  Write a program that reads the information about a company and
  its manager and prints them on the console.
*/

using System;

class ACompanyHas
{
    static void Main()
    {
        Console.WriteLine("Enter the company name:");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter the compay`s address:");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter the company`s phone number:");
        long companyPhoneNom = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the company`s fax number:");
        long companyFaxNum = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter the company`s web site:");
        string companyWebSite = Console.ReadLine();
        Console.WriteLine("Enter the company's manager name:");
        string managerName = Console.ReadLine();
        Console.WriteLine("Enter manager`s first name:");
        string managerFirstName = Console.ReadLine();
        Console.WriteLine("Enter manager`s last name:");
        string managerLastName = Console.ReadLine();
        Console.WriteLine("Enter the manager`s ages:");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter the manager`s phone number:");
        long managerPhoneNum = long.Parse(Console.ReadLine());

        Console.WriteLine("Company information:\nCompany name:{0}\nCompany address:{1}\nCompany phone number:{2}\nCompany fax number:{3}\nCompany web site:{4}\nCompany manager:{5}",
                           companyName, companyAddress, companyPhoneNom, companyFaxNum, companyWebSite, managerName);
        Console.WriteLine("Manager information:\nManager first name:{0}\nManager last name:{1}\nManager age:{2}\nManager phone number:{3}",
                           managerFirstName, managerLastName, age, managerPhoneNum);

    }
}

