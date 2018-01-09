using System;

class IsThirdDigit7
{
    static void Main()
    {
        int number = Math.Abs(int.Parse(Console.ReadLine()));

        number = (number / 100) % 10;

        bool isSeven = (number == 7);
        if (isSeven)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false " + number);
        }
    }
}