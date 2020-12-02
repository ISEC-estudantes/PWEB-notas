using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_ex2
{
    class FuncionarioVencimentoFixo : Funcionario
    {
        public int vencimento { get; private set; }

        public FuncionarioVencimentoFixo(string nome, string apelido, int NIF,int comissao, int vencimento)  : base(nome, apelido, NIF, comissao)
        {
            this.vencimento = vencimento;
        }

        public override int getVencimento()
        {
            return comissao * valorVendas + vencimento;
        }







    }
}
