using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Projeto Fatorial");

          

            for (int i = 1; i <= 10; i++)
            {
                int n = i;
                int fatorial = 1;

                for (int j = n; j >= 1 ; j--)
                {
                    if ((j - 1) != 0)
                    {
                        n = n * (j - 1);
                    }
                    else
                    {
                        break;
                    }       
                }
                fatorial = n;
                Console.WriteLine("O fatoria de "+i+ " é: "+fatorial);
            }
            Console.ReadLine();
        }
    }
}
