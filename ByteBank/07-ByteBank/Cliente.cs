using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class Cliente
    {
        private string _cpf;

        public string Nome { get; set; }
        public string CPF {
            get
            {
                return this._cpf;

            }
            set
            {
                //Aqui pode ter alguma logica de validaçao de CPF
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }
}
