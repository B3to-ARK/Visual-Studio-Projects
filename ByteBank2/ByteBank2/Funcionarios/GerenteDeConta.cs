﻿using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {    
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando um Gerente de Conta");
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }  
    }
}