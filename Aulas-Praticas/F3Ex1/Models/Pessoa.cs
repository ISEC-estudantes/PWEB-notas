using System;

namespace F3Ex1.Models
{
    public class Pessoa
    {
        public string Nome, Genero;
        public int Idade;
        public DateTime DataNascimento;

        public Pessoa(string nome, string genero, int idade, DateTime dataNascimento)
        {
            Nome = nome;
            Genero = genero;
            Idade = idade;
            DataNascimento = dataNascimento;
        }
    }
}