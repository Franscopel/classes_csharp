using System;

namespace Aula01Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o salario");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o total de vendas");
            double vendas = double.Parse(Console.ReadLine());

            double salarioFinal;

            if (vendas > 1500)
            {
                salarioFinal = salario + (vendas - 1500) * 0.1 + 75;
            }
            else
            {
                salarioFinal = salario + vendas * 0.05;
            }

            Console.WriteLine($"O salario final é {salarioFinal}");

        }
    }
}