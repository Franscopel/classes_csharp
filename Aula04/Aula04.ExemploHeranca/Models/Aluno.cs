using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.ExemploHeranca.Models
{
    //Aluno herda de Pessoa (O aluno possui os atributos e métodos da pessoa)
    public class Aluno: Pessoa
    {
        //Propriedades
        public int Matricula { get; set; }
        public string Curso { get; set; }

        //Construtor que invoca o construtor com nome da Pessoa
        public Aluno(string nome, int idade, int matricula,string curso) : base(nome, idade)
        {
            Matricula = Matricula;
            Curso = curso;
        }

        public Aluno(string nome, int matricula) : base(nome)
        {
            Matricula = matricula;
        }

        //Metodos
        public void ObterPresenca()
        {
            Console.WriteLine($"{Nome} presente");
        }

    }
}
