using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 - Calcula Poupança");

            double valorInvestido = 1000;
                       
            int n = 1;

            int i = 12;

            while (n <= i)
            {
                valorInvestido = valorInvestido + valorInvestido * ((0.36) / 100);
                Console.WriteLine("O valor após " + n + " meses sera de: "+ valorInvestido );

                //n += 1; 
                n++;
            }

            Console.ReadLine();
        }
    }
}
