﻿using System;

class Primes
{
    static void Main()
    {
        Console.Write("n = ");
        string numberAsString = Console.ReadLine();
        int n = int.Parse(numberAsString);

        Console.Write("m = ");
        numberAsString = Console.ReadLine();
        int m = int.Parse(numberAsString);

        if (1 < n && n < m)
        {
            for (int num = n; num <= m; num++)
            {
                bool prime = true;
                int divider = 2;
                int maxDivider = (int)Math.Sqrt(num);

                while (divider <= maxDivider)
                {
                    if (num % divider == 0)
                    {
                        prime = false;
                        break;
                    }

                    divider++;
                }

                if (prime)
                {
                    Console.Write("{0} ", num);
                }
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid range!");
        }
    }
}
