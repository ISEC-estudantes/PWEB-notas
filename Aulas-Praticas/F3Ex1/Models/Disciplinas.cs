using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Tracing;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace F3Ex1.Models
{
    public class Disciplinas
    {
        public Disciplinas()
        {
            id = ++idcounter;
            Nome = "nome";
            Curso = "curso";
            ECTS = 0;
            Semestre = 0;
        }

        [Key] 
        public int id { get; set; }

        [Display(Name = "Unidade Curricular")] public string Nome { get; set; }
        [Required]
        public string Curso{ get; set; }
        [Range(0, 20)]
        public int ECTS{ get; set; }
        public int Semestre{ get; set; }
        public static int idcounter= 0;

        public Disciplinas(string nome, string curso, int ects, int semestre)
        {
            id = ++idcounter;
            Nome = nome;
            Curso = curso;
            ECTS = ects;
            Semestre = semestre;
        }

        public Disciplinas(int id, string nome, string curso, int ects, int semestre)
        {
            this.id = id;
            ++idcounter;    
            Nome = nome;
            Curso = curso;
            ECTS = ects;
            Semestre = semestre;
        }

        static public List<Disciplinas> getList()
        {
            var aux = new List<Disciplinas>();
            aux.Add(new Disciplinas("Empreendedorismo", "LEI", 20, 1));
            aux.Add(new Disciplinas("pweb", "LEI", 20, 1));
            aux.Add(new Disciplinas("poo", "LEI", 20, 1));
            aux.Add(new Disciplinas("segurança", "LEI", 20, 1));
            return aux;
        
        
        }

        public static object getDisciplidaPorId(int i, List<Disciplinas> list) 
        {
            return list.Find(item => item.id == i);
        }
    }
}