using System;
using System.Numerics;

//using System.Numerics;

class Factorial
{
    static void Main()
    {
        Console.Write("n = ");
        string consoleInput = Console.ReadLine();
        int n = int.Parse(consoleInput);
        BigInteger factorial = 1;
        //BigInteger factorial = 1;

        do
        {
            factorial *= n;
            n--;
        }
        while (n > 0);

        Console.WriteLine("n! = " + factorial);
    }
}