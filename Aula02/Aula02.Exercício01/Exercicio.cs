using System;
using Aula02.Exercicio01.Models;

namespace Aula02.Exercicio01
{
    class Exercicio
    {
        static void Main(string[] args)
        {
            //Criando os objetos (instanciando)
            Cor cor = new Cor();
            Carro carro = new Carro();

            //Ler os dados
            Console.WriteLine("Digite o modelo do carro");
            carro.Modelo = Console.ReadLine();

            Console.WriteLine("Digite o ano");
            carro.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o comprimento");
            carro.Comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a placa");
            carro.Placa = Console.ReadLine();

            Console.WriteLine("Digite o valor");
            carro.Valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Possui ar condicionado");
            carro.ArCondicionado = bool.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da cor do carro");
            cor.Nome = Console.ReadLine();

            Console.WriteLine("Digite o R");
            cor.R = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o G");
            cor.G = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o B");
            cor.B = int.Parse(Console.ReadLine());

            //Atribuir a cor do carro
            carro.Cor = cor;

            //Exibir os dados do carro
            Console.WriteLine($"Modelo: {carro.Modelo}, ano: {carro.Ano}, " +
                $"comprimento: {carro.Comprimento}, placa: {carro.Placa}, " +
                $"valor: {carro.Valor}, ar=condicionado: {carro.ArCondicionado}," +
                $"cor: {carro.Cor.Nome} ({carro.Cor.R}, {carro.Cor.G}, {carro.Cor.B}) ");

        }
    }
}
