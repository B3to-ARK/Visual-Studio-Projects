using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando um Funcionario");

            this.CPF = cpf;

            this.Salario = salario;

            TotalDeFuncionarios++;
        }

        // o this no construtor indica qual construtor será executado antes
        public Funcionario(string cpf) : this(1500, cpf) 
        {
            // Ahá! Nosso código está sem repetições e simplificado
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();    
    }
}
