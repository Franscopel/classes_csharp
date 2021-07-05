using Aula04.Exemplo01.Models;
using System;

namespace Aula04.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um carro utilizando o construtor padrão
            //var gol = new Carro("Gol");

            //Instanciar um carro utilizando o construtor com o modelo
            var celta = new Carro("Celta 1.0");

            //Instanciar um carro utilizando o construtor com dois argumentos
            var gol = new Carro("Gol", 2010);

            //Exibir os valores dos objetos
            Console.WriteLine($"Modelo: {celta.Modelo}, Ano: {celta.Ano}");
            Console.WriteLine($"Modelo: {gol.Modelo}, Ano: {gol.Ano}");

            //Instanciar a moto utilizando o construtor padrão, informando os vlaores p/ as propriedades
            //opcional somente var honda = new Moto();
            var honda = new Moto()
            {
                Cilindrada = 100,
                Passageiros = 2
            };

            //Exibir os dados da moto
            Console.WriteLine($"Cilindrada: {honda.Cilindrada}, Passageiros: {honda.Passageiros}");

        }
    }
}
