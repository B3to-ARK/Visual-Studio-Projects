using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 5 - Caracteres e Textos");

            char primeiraLetra = 'A';

            Console.WriteLine("Exibindo o primeiro caractere: " + primeiraLetra);

            Console.WriteLine();

            Console.WriteLine("Exibindo outro caractere: " + (primeiraLetra = (char) 61));

            Console.WriteLine();

            string frase = "essa é minha primeira frase ";

            /*
             *a string aceita apenas "" sem nada escrito
             * mas o char nao aceita '' sem nada escrito
             * 
             */


            Console.WriteLine("Segue a primeira frase:  " + frase);

            Console.WriteLine();

            Console.WriteLine("Segue a segunda frase: " + (frase = frase + 2020));

            Console.WriteLine();

            string testeVariasLinhas = @"esta é
uma string
separa em 
varias linhas";

            Console.WriteLine(testeVariasLinhas);

            Console.WriteLine();

            Console.WriteLine("aperta enter ae");
            Console.ReadLine();

        }
    }
}
