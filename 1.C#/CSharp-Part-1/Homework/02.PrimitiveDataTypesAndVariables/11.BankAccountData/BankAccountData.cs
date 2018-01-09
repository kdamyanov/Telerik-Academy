using System;

//A bank account has a holder name(first name, middle name and last name), available amount of money(balance), bank name, IBAN, 3 credit card numbers associated with the account.Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

class BankAccountData
{
    static void Main()
    {
        String holderName = "Kiril Ilchev Damyanov";
        decimal amount = 10000.50M;
        String bankName = "Post Bank";
        String IBAN = "BG 4567 UR 4567 5467 345 23";
        String creditCard1 = "456 34567 333 333 555";
        String creditCard2 = "456 34567 333 333 666";
        String creditCard3 = "456 34567 333 333 666";

        Console.WriteLine("Holder name:{0}\nAmount:{1} BGN\nBank name:{2}\nIBAN:{3}\nVisa:{4}\nAmex:{5}\nAmex Gold:{6}", holderName, amount, bankName, IBAN, creditCard1, creditCard2, creditCard3);


    }
}

