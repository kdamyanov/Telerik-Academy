using System;

public class IfStatementExample
{
    static void Main()
    {
        Console.Write("Enter a number in the range [1..7]: ");

        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1: 
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Thusday");
                break;
            case 3: 
                Console.WriteLine("Friday");
                break;
            default:
                Console.WriteLine("not this day");
                break;
        }
    }
}