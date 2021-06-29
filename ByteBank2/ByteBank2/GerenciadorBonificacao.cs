using ByteBank2.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank2
{
    class GerenciadorBonificacao
    {

        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this._totalBonificacao += funcionario.GetBonificacao();
        }

        /*
        public void Registrar(Diretor diretor)
        {
            this._totalBonificacao += diretor.GetBonificacao();
        }
        */
        public double GeTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
