using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("11 - Calcula Poupança 2");

            double valorInvestido = 1000;

            for (int i = 1; i <= 12; i++)
            { 
                valorInvestido = valorInvestido + valorInvestido * ((0.36) / 100);
                Console.WriteLine("O valor após " + i + " meses sera de: " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
