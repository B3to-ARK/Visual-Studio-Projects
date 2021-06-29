using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CalculaInvestimentoLongoPraso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 12 - Calcula Investimento Longo Prazo");

            double fatorRendimento = 1.0036;

            double valorIvestido = 1000;

            for (int i = 1; i <= 5; i++)
            {
              
                for (int j = 1; j <= 12; j++)
                {
                    valorIvestido = valorIvestido * fatorRendimento;
                }
                fatorRendimento += 0.001;
            }

            Console.WriteLine("Ao termino do investimento vc tera: " + valorIvestido);

            Console.ReadLine();
        }
    }
}
