using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_ex2
{
    abstract class Funcionario
    {

        public string nome { get; private set; }
        public string apelido { get; private set; }
        public int NIF { get; private set; }

        public int valorVendas { get; private set; }
        public int comissao { get; private set; }

        public Funcionario(string nome, string apelido, int NIF, int comissao = 0)
        {
            this.nome = nome;
            this.apelido = apelido;
            this.NIF = NIF;
            this.valorVendas = 0;
            this.comissao = comissao;

        }

        public void addValorVenda(int valor) { valorVendas += valor; }

        // public String toString(){
        //     return this.toString();
        // }

        

        public virtual int getVencimento()
        {
            return comissao * valorVendas;
        }


    }
}
