﻿using System;
using System.Text;

//Find online more information about ASCII(American Standard Code for Information Interchange) and write a program that prints the visible characters of the ASCII table on the console(characters from 33 to 126 including).
//Note: You may need to use for-loops(learn in Internet how).

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        for (int i = 33; i <=126; i++)
        {
            Console.Write((char)i);
        }
    }
}