﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 9 - Escopo");

            int idade = 0;
            int quantidadedepessoas = 1;

            bool acompanhado = quantidadedepessoas >= 2;

            string mensagemAdicional;

            if (acompanhado == true) 
            {
                mensagemAdicional = "o cara ta acompanhado";
            }
            else mensagemAdicional = "o cara nao ta acompanhado";
            
            if (idade >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(mensagemAdicional);
            }

            Console.ReadLine();
        }
    }
}