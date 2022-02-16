using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorozatKiir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Adja meg hogy meddig irja ki a program a számokat! ");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adja meg hogy mettől irja ki a program a számokat! ");
            int min = Convert.ToInt32(Console.ReadLine());
            if (max >= 1 && min >=1 && max > min)
            {
                for (int i = min; i <= max; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Hibás érték");
            }
        }
    }
}
