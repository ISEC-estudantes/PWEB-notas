
using System.Collections.Generic;
using f1_ex1;


namespace Exercicio_3{
    enum OrdernarPor{
        Nome,
        Prioridade,
        Categoria,
        Estado,
        DataLimite,
        DataRegisto
    }

    class Utilizador
    {
        public string Nome { get; }
        public List<Tarefa> Tarefas { get; }

        public Utilizador(string Nome)
        {
            this.Nome = Nome;
            Tarefas = new List<Tarefa>();
        }

        public void AdicionarTarefa(string NomeTarefa = null)
        {}

        public void AdicionarTarefa(Tarefa t)
        {}
    }
}