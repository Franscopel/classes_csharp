using Aula04.ExemploHeranca.Models;
using System;

namespace Aula04.ExemploHeranca02
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar um Aluno
            var aluno = new Aluno(nome: "Snarf", matricula: 123);

            //Atribuir um nome ao aluno
            ///Nome com protected internal não é visível aqui
            //aluno.Nome = "Snarf";
            //aluno.Matricula = 123
            //aluno.Idade = 7;

            //Instanciar uma Pessoa
            var pessoa = new Pessoa("Snarf");

            pessoa.Nome = "Snarf";

            //chama o nome ......
        }
    }
}
