using Aula05.Exemplo.Models;
using System;

namespace Aula05.Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar uma pessoa
            //var pessoa = new Pessoa() -> não tem como instanciar por estar na classe abstract

            //Instanciar uma Pessoa Fisica e atribuir um valor para o Sexo
            var pf = new PessoaFisica()
            {
                Nome = "Ricardo",
                Sexo = Genero.Masculino
            };

            //Validar se o sexo é feminino
            if (pf.Sexo == Genero.Feminino)
                Console.WriteLine("O genero é feminino");
            else
                Console.WriteLine("O genero não é feminino");

            //Exibir o valor do sexo
            Console.WriteLine(pf.Sexo);
            Console.WriteLine((int)pf.Sexo); //Exibw o valor da constante
        }
    }
}
