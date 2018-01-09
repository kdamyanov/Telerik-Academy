using System;

class Program
{
    static void Main()
    {
        for (int number = 2; number <= 11; number++)  //for-loop, който ще ни позволи да обходим всички числа от 2 до 11 вкл.                                        //number e променливата, която ще управлява  цикъл
                                                      //при първата итерация number ще има   стойност 2
                                                      //цикълът ще продължава докато number е по-малко или равно на 11
                                                      //на всяка итерация number ще се увеличава с 1 (number++)
        {
            if (number%2==0)                            //% - делене с остатък
                                                        //ако върне 0, значи числото е четно
            {
                Console.WriteLine(number);
            }
            else                                        //изпълнява се, ако условието в If-a е  невярно                                                            
                                                        //т.е. number%2 връща 1 (нечетно е)
            {
                Console.WriteLine(-number);
            }
        }
    }
}

