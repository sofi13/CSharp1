using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("My Age Now");
        int Age = int.Parse(Console.ReadLine());
        Age += 10;
        Console.WriteLine("My age after ten years:"+Age);
    }
}

