using System;

class Age
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;
        DateTime birtday = DateTime.Parse(Console.ReadLine());
        System.TimeSpan ageNow = currentDate - birtday;
        double yourAge  = ageNow.TotalDays / 365.25;
        Console.WriteLine(((int)yourAge));
        Console.WriteLine(((int)yourAge +10));
    }
}
 
