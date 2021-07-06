﻿using Aula04.ExercicioFormacao.Models;
using System;

namespace Aula04.ExercicioFormacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler o tipo de formacao que será criada
            Console.WriteLine("Escolha: 1-Tecnologo ou 2-Bacharelado");
            int opFormacao = int.Parse(Console.ReadLine());

            // Ler o nome
            Console.WriteLine("Digite o nome da formação");
            string nomeFormacao = (Console.ReadLine());

            //Declaar a variável que armazena o objeto da formação
            Formacao formacao;

            //Ler o trabalho conclusão e carga horária estágio, se for bacharelado
            if (opFormacao == 2)
            {
                Console.WriteLine("Digite o titulo do TCC");
                string tcc = Console.ReadLine();
                Console.WriteLine("Digite a carga horaria do estagio");
                int cargaHoraria = int.Parse(Console.ReadLine());

                //Instanciar a classe
                formacao = new Bacharelado(nomeFormacao, cargaHoraria)
                {
                    ProjetoConclusao = tcc
                };
            }
            else
            {
                formacao = new Tecnologo(nomeFormacao);
            }

            //Exibir os dados do objeto
            Console.WriteLine(formacao);

            //Menu para calcular mensalidade, calcular média e sair
            int opcao;
            do
            {
                Console.WriteLine("Digite 1-Calcular Mensalidade \n2-Calcular Média \n0-sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine($"A mensalidade é :{formacao.CalcularMensalidade()}");
                        break;
                    case 2:
                        //Ler as 3 notas e exibir a média
                        Console.WriteLine("Digite a nota 1");
                        float nota1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota 2");
                        float nota2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nota 3");
                        var nota3 = float.Parse(Console.ReadLine());
                        Console.WriteLine($"A média é {formacao.CalcularMedia(nota1, nota2, nota3)}");
                        break;
                    case 0:
                        Console.WriteLine("Finalizando o sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine(formacao);

            } while (opcao != 0);

        }
    }
}
