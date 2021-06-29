using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção capturada no metodo Main.");
                //throw;
            }


            Console.WriteLine("Execução finalisada tecle enter para sair.");
            Console.ReadLine();
        }



        private static void CarregarContas()
        {

            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            //-------------------------------------------------------------------------



            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //finally
            //{
            //    if (leitor != null)
            //    {
            //        leitor.Fechar();
            //    }
            //}
        }



        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);


            }
            /* catch (ArgumentException ex)
             {
                 Console.WriteLine("Argumento com problema: " + ex.ParamName);
                 Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException.");
                 Console.WriteLine(ex.Message);
             }
             catch (SaldoInsuficienteException e)
             {
                 Console.WriteLine(ex.Saldo);
                 Console.WriteLine(ex.ValorSaque);
                 Console.WriteLine(ex.StackTrace);
                 Console.WriteLine(ex.Message);
             }*/
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }



    }
}
