/*A bank account has a holder name (first name, middle name and last name), 
  available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers 
  associated with the account. Declare the variables needed to keep the information 
  for a single bank account using the appropriate data types and descriptive names.
 */ 

using System;

class BankAccount 
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        object fullName = firstName + " " + middleName + " " + lastName;
        Console.WriteLine("Personal information: {0}", fullName);

        decimal balance = 150.96M;
        string bankName = "IAB Bank";
        string iban = "IAB TH 2566 5188 2545";
        string bic = "ASDFGH";
        Console.WriteLine("Amound information: \nBank- {0}\nIBAN- {1}\nBIC- {2}", bankName, iban, bic);

        long cartOne = 555599998888;
        long cartTwo = 444488887777;
        long cartThree = 333377776666;
        Console.WriteLine("Credit carts information:\nCart one {0}\nCart two {1}\nCart three {2}", cartOne, cartTwo, cartThree);
    }
}

