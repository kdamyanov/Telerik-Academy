using System;

class Program
{
    static void Main()
    {

        // Find the bit at position p in n
        int p = 5;
        int n = 35;               // 00000000 00100011

        //int mask = 1 << p;        // 00000000 00100000
        //int nAndMask = n & mask;  // 00000000 00100000
        //int bit = nAndMask >> p;  // 00000000 00000001
        //Console.WriteLine(bit);   // 1
        //Console.WriteLine(Convert.ToString(bit, 2).PadLeft(32, '0'));

        //int bitShort = (n & (1 << p) >> p);
        //Console.WriteLine(bitShort);
        //Console.WriteLine(Convert.ToString(bitShort, 2).PadLeft(32, '0'));

        //int bitShort2 = (n >> p) & 1;
        //Console.WriteLine(bitShort2);
        //Console.WriteLine(Convert.ToString(bitShort2, 2).PadLeft(32, '0'));

        //Set the bit at position p to 0 in a number n
        p = 5;
        n = 35;                            // 00000000 00100011
        int mask = ~(1 << p);              // 11111111 11011111
        int result = n & mask;              //00000000 00000011
        Console.WriteLine(result);         // 3
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));

        //How to set the bit at position p to 1

        //p = 4;
        //n = 35;                          // 00000000 00100011
        //int mask = 1 << p;               // 000000000 0010000
        //int result = n | mask;           // 00000000 00110011
        //Console.WriteLine(result);       // 51
        //Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}

