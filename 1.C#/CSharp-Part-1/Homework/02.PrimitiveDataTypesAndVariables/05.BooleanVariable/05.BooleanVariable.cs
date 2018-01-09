using System;

//Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.Print it on the console.

class BooleanVariable
{
    static void Main()
    {
        bool isFamele = false;
        Console.Write("Are you a female? (Yes/No): ");
        String answer = Console.ReadLine();
        if(answer == "Yes")
        {
            isFamele = true;
            Console.WriteLine(isFamele);
        }
        else if (answer == "No")
        {
            isFamele = false;
            Console.WriteLine(isFamele);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
