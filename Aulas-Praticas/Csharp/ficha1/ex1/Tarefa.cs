using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_ex1
{
    enum Prioridade
    {
        Low,
        Medium,
        High
    }

    enum Categoria
    {
        Pessoal,
        Trabalho
    }

    enum Estado
    {
        PorExecutar,
        AExecutar,
        Concluida
    }

    class Tarefa
    {

        public string nome { get; private set; }
        public Prioridade prioridade { get; private set; }
        public Categoria categoria { get; private set; }
        public Estado estado { get; private set; }
        public DateTime dataRegisto { get; private set; }
        public DateTime dataLimite { get; private set; }


        public Tarefa(string nome, Prioridade prioridade, Categoria cateoria, Estado estado, int diasParaLimite)
        {

            this.nome = nome;
            this.prioridade = prioridade;
            this.categoria = categoria;
            this.estado = estado;
            dataRegisto = DateTime.Now;
            dataLimite = dataLimite.AddDays(diasParaLimite);

        }
    }
}
