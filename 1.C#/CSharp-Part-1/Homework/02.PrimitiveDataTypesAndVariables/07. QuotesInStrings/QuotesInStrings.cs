﻿using System;

class QuotesInStrings
{
    static void Main()
    {
        String a = "The \"use\" of quotations causes difficulties.";
        String b = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(b);
    }
}   

