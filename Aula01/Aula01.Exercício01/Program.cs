using System;

namespace Aula01.Exercício01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler o valor do veiculo
            Console.WriteLine("Digite o valor");
            double custoFabrica = double.Parse(Console.ReadLine());

            //Realizar o calculo
            double porcentagemDistribuidor = custoFabrica * 0.29;
            double impostos = custoFabrica * 0.46;
            double valorFinal = custoFabrica + porcentagemDistribuidor + impostos;

            //Exibir o valor obtido
            Console.WriteLine($"O valor final é {valorFinal}");
        }
    }
}