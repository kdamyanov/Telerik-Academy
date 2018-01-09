using System;

class PrintLongSequence
{
    static void Main()
    {
        for (int number = 2; number <= 1001; number++)                                  
        {
            if (number % 2 == 0)                           
            {
                Console.WriteLine(number);
            }
            else                                      
            {
                Console.WriteLine(-number);
            }
        }
    }
}