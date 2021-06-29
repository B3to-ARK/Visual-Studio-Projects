using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 3 + Projeto 4 - Criando Variaveis Ponto Flutuante");

            double salario = 1200.70;

            Console.WriteLine("Seu salario é: " + salario);

            salario = (int) salario;

            Console.WriteLine("O novo salario agora é um numero inteiro: " + salario);
                 
            Console.WriteLine("O novo salario ainda é um numero inteiro mesmo seu eu dividir por 7: " + (salario = 1200 / 7));

            salario = salario * 5.5;

            Console.WriteLine("O novo salario agora é um ponto flutuante: " + salario);

            /* 
             * long é um int de 64bits
             * o int suporta ate 32bits
             * o short é um int de 16bits
             * 
             */

            /*
             * o float é um double com menor precisão de casa decimais
             * no float tem que por o sufixo f 
             * 
             * Ex.: float salario = 1200.70f
             * 
             */
             
            Console.WriteLine("Aperta enter ae");
            Console.ReadLine();
        }
    }
}
