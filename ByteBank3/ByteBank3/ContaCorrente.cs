using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank3
{
    public class ContaCorrente
    {

        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;

        public int Agencia{ get; }

        public int Numero { get; }

        private double saldo = 100;

        public int ContadorSaquesNaoPermitidos { get; private set; }

        public int ContadorTranferenciasNaoPermitidas { get; private set; }



        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    this.saldo = value;
                }
            }
        }



        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if (numeroAgencia <= 0 && numeroConta <= 0)
            {

            }
            if (numeroAgencia <= 0)
            {
                ArgumentException excecao = new ArgumentException("O argumento agencia deve ser maior que zero.", nameof(numeroAgencia));

                throw excecao;

            }
            if (numeroConta <= 0)
            {
                ArgumentException excecao = new ArgumentException("O argumento numero deve ser maior que zero.", nameof(numeroConta));

                throw excecao;
            }
            else
            {

                this.Agencia = numeroAgencia;
                Numero = numeroConta;

                ContaCorrente.TotalDeContasCriadas++;

                TaxaOperacao = 30 / TotalDeContasCriadas;

            }
        }



        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para o saque.", nameof(valor));
            }
            if (this.saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(this.saldo, valor);
            }
            else
            {
                this.saldo -= valor;
            }

        }



        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo += valor;
            }
        }



        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para o saque.", nameof(valor));
            }
            else
            {
                try
                {
                    Sacar(valor);
                    contaDestino.Depositar(valor);
                }
                catch (SaldoInsuficienteException e)
                {
                    ContadorTranferenciasNaoPermitidas++;
                    throw new OperacaoFinanceiraException("Operação não realizada.", e);
                }

            }
            
        }



    }
}