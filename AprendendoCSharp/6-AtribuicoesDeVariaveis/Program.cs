using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 - Atribuições de Variaveis");

            int idade = 20;

            int idadeBeto = idade + 8;

            Console.WriteLine(idadeBeto);

            idade = 10;

            Console.WriteLine(idade);

            Console.ReadLine();
        }
    }
}
