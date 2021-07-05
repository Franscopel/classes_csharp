using Aula04.ExemploHeranca.Models;
using System;

namespace Aula04.ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Aluno
            var aluno = new Aluno();

            //Atribuir o nome ao aluno
            aluno.Nome = "Wendy";
            aluno.Matricula = 123;


            //Instanciar uma Pessoa
            var pessoa = new Pessoa();

            pessoa.Nome = "Snarf";

            //Chamar o método retornar dados e exibir o resultado
            Console.WriteLine(aluno.RetornarDados());
            Console.WriteLine(pessoa.RetornarDados());

            aluno.ObterPresenca();
            //pessoa.ObterPresenca(); pessoa não possui o método
        }
    }
}
