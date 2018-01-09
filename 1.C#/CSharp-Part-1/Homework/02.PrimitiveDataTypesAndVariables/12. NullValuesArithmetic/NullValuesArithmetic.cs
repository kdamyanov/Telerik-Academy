using System;

//Create a program that assigns null values to an integer and to a double variable.
//-Try to print these variables at the console.
//-Try to add some number or the null literal to these variables and print the result.

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("{0}{1}", a,b);
        a +=15;
        b +=10;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

