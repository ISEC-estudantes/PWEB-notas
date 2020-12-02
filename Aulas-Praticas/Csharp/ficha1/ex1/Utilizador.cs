using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_ex1
{
    class Utilizador
    {
        public string nome { get; private set; }
        public List<Tarefa> listaTarefas { get; private set; }


        public List<Tarefa> enumerate()
        {
            return listaTarefas;
        }

        public List<Tarefa> enumerateByPrioridade()
        {
            listaTarefas.Sort((x, y) => x.prioridade.CompareTo(y.prioridade));
            return listaTarefas;
        }

        public List<Tarefa> enumerateByCategoria()
        {
            listaTarefas.Sort((x,y) => x.categoria.CompareTo(y.categoria));
            return listaTarefas;
        }

        public List<Tarefa> enumerateByEstado()
        {
            listaTarefas.Sort((x,y) => x.estado.CompareTo(y.estado));
            return listaTarefas;
        }

        public void removeTarefasConcluidas()
        {
            listaTarefas.RemoveAll((x) => x.estado == Estado.Concluida);
        }
      
        public void removeTarefasPessoais()
        {
            listaTarefas.RemoveAll(x => x.categoria == Categoria.Pessoal);
        }

        public void removeTarefasPoucoPriritarias()
        {
            listaTarefas.RemoveAll(x => x.prioridade == Prioridade.Low);
        }


    }
}
