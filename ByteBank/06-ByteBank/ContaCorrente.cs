
namespace _06_ByteBank
{
    public class ContaCorrente
    {
         public Cliente Titular { get; set; }

        /*
         * esse codigo comentado abaixo faz a mesma coisa que o de cima
    public Cliente Titular { get; set; }
{
        get
        {
            return this._titular;
        }
        set
        {
            _titular = value;
        }

}
        */


        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double saldo = 100;

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


        /*

        esse bloco comentado aqui foi representado no metodo acima 
        que faz exatamente a mesma coisa
        do que esse dois metodos abixo

        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            else
            {
                this.saldo = saldo;
            }
        }

        public double GetlSaldo()
        {
            return this.saldo; 
        }


    */



        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            return true;
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

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
