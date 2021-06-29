using ByteBank2.Funcionarios;
using ByteBank2.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalcularBonificacao();

            UsarSistema();

            /* 
             * isso seria feito se o metodo CalcularBonificacao()
             * nao fosse estatico
             * 
             * 
            Program program = new Program();
            program.CalcularBonificacao();
            *
            */
            
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            //o diretor é uma classe de exeplo de como passar mais de um argumento na criação
            //as demias classes o salario é passado por argumento durente o extend
            Diretor roberta = new Diretor(5000, "454.658.145-3");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";
            camila.Senha = "abc";


            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "123456";

            SistemaInterno sistemaInterno = new SistemaInterno();
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abc");
            sistemaInterno.Logar(parceiroComercial, "123456");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-039");
            pedro.Nome = "Pedro";

            //o diretor é uma classe de exeplo de como passar mais de um argumento na criação
            //as demias classes o salario é passado por argumento durente o extend
            Diretor roberta = new Diretor(5000, "454.658.145-3");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("326.985.628-89");
            camila.Nome = "Camila";

            Desenvolvedor guilherme = new Desenvolvedor("456.175.468-20");
            guilherme.Nome = "Guilherme";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(guilherme);

            Console.WriteLine("Total de bonificações do mes: "+ gerenciadorBonificacao.GeTotalBonificacao());
        }
    }
}
