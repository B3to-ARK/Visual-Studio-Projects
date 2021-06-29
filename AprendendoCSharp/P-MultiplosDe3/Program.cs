using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_MultiplosDe3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Projeto Multiplos de 3");

            int a = 0;

            for (int i = 1; i <= 100; i++)
            {
                /*
                 * 
                if (i % 3 == 0)
                {
                    Console.WriteLine("o numero "+ i +" é multiplo de 3");
                }
                *
                */

                a = a + 3;
                if (a > 99)
                {
                    break;
                }
                Console.WriteLine("o numero " + a + " é multiplo de 3");
               
            }

            Console.ReadLine();

        }
    }
}
