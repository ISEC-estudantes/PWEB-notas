using System.Collections.Generic;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace F3Ex1.Models
{
    public class Disciplinas
    {
        public int id;

     

        public string Nome;
        public string Curso;
        public int ECTS;
        public int Semestre;


        public Disciplinas(int id, string nome, string curso, int ects, int semestre)
        {
            this.id = id;
            Nome = nome;
            Curso = curso;
            ECTS = ects;
            Semestre = semestre;
        }

        static public List<Disciplinas> getList()
        {
            var aux = new List<Disciplinas>();
            aux.Add(new Disciplinas(1,"Empreendedorismo", "LEI", 20, 1));
            aux.Add(new Disciplinas(2,"pweb", "LEI", 20, 1));
            aux.Add(new Disciplinas(3,"poo", "LEI", 20, 1));
            aux.Add(new Disciplinas(4,"segurança", "LEI", 20, 1));
            return aux;


        }

        public static object getDisciplidaPorId(int i, List<Disciplinas> list) 
        {
            return list.Find(item => item.id == i);
        }
    }
}