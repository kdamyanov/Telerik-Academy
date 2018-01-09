using System;


class DivideBy7and5

{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        bool b = (a % 5 == 0 && a % 7 == 0);
        if (b)
        {
            Console.WriteLine("true " + a);
        }
        else
        {
            Console.WriteLine("false " + a);
        }
    }
}

