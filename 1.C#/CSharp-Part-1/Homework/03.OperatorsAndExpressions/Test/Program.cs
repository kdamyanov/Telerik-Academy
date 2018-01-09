using System;

public class Money
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        while (number > 0)
        {
            int remainder = number % 10;
            number /= 10;
            Console.WriteLine(remainder);
        }
    
    }
}
