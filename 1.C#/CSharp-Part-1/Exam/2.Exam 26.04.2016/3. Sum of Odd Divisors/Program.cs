using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sum_of_Odd_Divisors
{
    class Program
    {
        static void Main()
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());

            int result = 0;


            for (int i = numberA; i <= numberB; i ++)
            {
                if (numberB % numberA == 0)
                {
                    continue;
                }
                
            }

            }
        }
    }
