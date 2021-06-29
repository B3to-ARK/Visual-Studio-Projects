using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 8 - Condicionais 2");

            int idade = 0;
            int quantidadedepessoas = 2;

            bool acompanhado = quantidadedepessoas >= 2;

            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não Pode entrar");
            }

            Console.ReadLine();
        }
    }
}
