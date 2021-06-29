using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            int i = 0;
            
              
            if (salario >= 1900 && salario <= 2800)
            {
                i = 1;
            }
            if (salario >= 2800.01 && salario <= 3751)
            {
                i = 2;
            }
            if (salario >= 3751.01 && salario <= 4664)
            {
                i = 3;
            }

           

            switch (i)
            {
                case 1:
                    Console.WriteLine("o IR é de 7.5 % e pode deduzir na declaração o valor de R$ 142");
                    break;
                case 2:
                    Console.WriteLine("o IR é de 15% e pode deduzir R$ 350");
                    break;
                case 3:
                    Console.WriteLine("o IR é de 22.5% e pode deduzir R$ 636");
                    break;
            }

            Console.ReadLine();
        }
    }
}
