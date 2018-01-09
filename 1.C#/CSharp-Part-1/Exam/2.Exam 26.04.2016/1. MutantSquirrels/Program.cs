using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.MutantSquirrels
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfTrees = long.Parse(Console.ReadLine());
            long numberOfBranches = long.Parse(Console.ReadLine());
            long numberOfSquirrels = long.Parse(Console.ReadLine());
            long averageNumberOfTails = long.Parse(Console.ReadLine());

            long numberOfSquirrelsTails = numberOfTrees * numberOfBranches * numberOfSquirrels * averageNumberOfTails;

            if (numberOfSquirrelsTails % 2 == 0)
            {
                long multiplyR = 376439;
                double totalresult = (double)numberOfSquirrelsTails * multiplyR;
                Console.WriteLine("{0:F3}", totalresult);
            }
            else
            {
                double totalresult = (double)numberOfSquirrelsTails / 7;
                Console.WriteLine("{0:F3}", totalresult);
            }
        }
    }
}
