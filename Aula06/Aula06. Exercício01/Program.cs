using Aula06._Exercício01.Models;
using System;
using System.Collections.Generic;
using System.Linq;


// Classe Captura os dados -> Interface que cadastra no banco

namespace Aula06._Exercício01
{
    class Program
    {
        public static string Nome { get; private set; }

        static void Main(string[] args)
        {
            //Criar uma lista para armazenar alunos
            var lista = new List<Aluno>();

            do
            {
                //Ler os dados do aluno
                Console.WriteLine("Informe o nome do aluno");
                var nome = Console.ReadLine();

                Console.WriteLine("Informe a nota do aluno");
                var nota = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe o gênero do aluno");
                //Transforma uma string em um valor do Enum, (Genero) cast -> forçar o objeto ser do tipo Genero
                                                                                   // não diferenciar maiusculas e minusculas
                Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(), true);

                //Instanciar o aluno com os valores
                var aluno = new Aluno() //ou Aluno aluno = new Aluno()
                {
                    Genero = genero,
                    Nome = nome,
                    Nota = nota,
                };

                //Adicionar o objeto aluno na lista
                lista.Add(aluno);

                Console.WriteLine("Deseja adicionar mais um aluno? (true/false) ");
            } while (bool.Parse(Console.ReadLine()));

            //Percorrer a lista e exibir o nome dos alunos - utilizar o "for" OU o "foreach".
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].Nome);
            }

            float somaNotas = 0;
            foreach (Aluno item in lista)
            {
                Console.WriteLine(item.Nome);
            }

            //Exibir o total de alunos cadastrados 
            Console.WriteLine($"O total de alunos é {lista.Count}");

            //Exibir a media geral das notas
            Console.WriteLine($"A média das notas é {somaNotas / lista.Count}");
                                              //Average -> Método que retorna a média da propriedade selecionada
            Console.WriteLine($"A média das notas é {lista.Average( a => a.Nota)}");

            //Exbir a porcentagem por genero
            //Count() -> conta de acordo com o filtro
            Console.WriteLine($"A porcentagem de alunas é {(float)lista.Count(a => a.Genero == Genero.Feminino) / lista.Count}");
            Console.WriteLine($"A porcentagem de alunos é {(float)lista.Count(a => a.Genero == Genero.Masculino) / lista.Count}");
            Console.WriteLine($"A porcentagem de alunos de outros gêneros é {(float)lista.Count(a => a.Genero == Genero.Outros) / lista.Count}");

            int opcao;

            do
            {
                Console.WriteLine("Digite: \n1-Exibir nome e médias \n2-Alunos acima de 6 \n3-Aluno por genero \n0-Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        //Exibir o nome e média de todos os alunos
                        foreach (var item in lista)
                        {
                            Console.WriteLine($"Nome: {item.Nome}, Média: {item.Nota} ");
                        }
                        break;
                    case 2:
                        //Exibir o nome e nota dos alunos acima de 6
                        //Filtrar a lista com os alunos com nota maior do que 6
                        var listaFiltrada = lista.Where(churros => churros.Nota > 6).ToList();
                        for (int i = 0; i < listaFiltrada.Count; i++)
                        {
                            Console.WriteLine($"Nome: {listaFiltrada[i].Nome}, Nota: {listaFiltrada[i].Nota}");
                        }
                        //foreach (var item in listaFiltrada)
                        //{
                        //Console.WriteLine($"Nome: {item.Nome}, Nota: {item.Nota}");
                        //}  

                        break;
                    case 3:
                        //Ler o genero
                        Console.WriteLine("Digite o gênero para a pesquisa");
                        Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(), true);
                        //Exibir os alunos por genero
                        listaFiltrada = lista.Where(a => a.Genero == genero).ToList();
                        foreach (var item in listaFiltrada)
                        {
                            Console.WriteLine($"Nome: {item.Nome}");
                        }

                        break;
                    case 0:
                        Console.WriteLine("Finalizando o sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (opcao != 0);

        }
    }
}
