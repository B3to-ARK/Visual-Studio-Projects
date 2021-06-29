using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 7 - Condicionais");

            double idade = 0;

            if (idade > 18)
            {
                Console.WriteLine("Maior de 18");
            }
            else if (idade < 18)
            {
                Console.WriteLine("Menor de 18");
            }
            else
            {
                Console.WriteLine("Igual a 18");
            }

            Console.ReadLine();

        }
    }
}
