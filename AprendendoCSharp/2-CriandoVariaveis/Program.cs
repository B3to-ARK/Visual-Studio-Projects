using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Cirando Variaveis");

            int idade = 28;

            Console.WriteLine(("Sua idade é: " +idade));

            idade += 2;

            Console.Write("A idade agora é 28+5*10: "+(idade + 5 * 10));

            Console.WriteLine(" aperta enter ae");

            Console.ReadLine();
        }
    }
}
