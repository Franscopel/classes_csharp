using Aula04.ExercicioProduto.Models;
using System;

namespace Aula04.ExercicioProduto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Produto e Eletronico
            var produto = new Produto(1, "Camiseta"); //poderia ler os valores
            var eletronico = new Eletronico(2, "Notebbok")
            {
                Garantia = true,
                Preco = 2500
            };
            var livro = new Livro(3, "O poder do Habito", "Charles Duhigg")
            {
                Preco = 40
            };

            //DateTime utiliza o construtor com ano, mês, dia
            var arroz = new Perecivel(4, "Arroz", new DateTime(2022, 12, 25));

            //CTRL + D duplica a linha
            //Chamar método para calcular o desconto - pode ser qquer produto, todos tem o desconto 
            Console.WriteLine($"O valor com desconto de 10% é {livro.CalcularDesconto(20)}");
            Console.WriteLine($"O valor com desconto padrão é {livro.CalcularDesconto()}");
            Console.WriteLine($"O valor com cupom é {livro.CalcularDesconto("FIAPBOOK")}");

            //Chamar método para calcular o valor da garantia e exibir o resultado -  somente o eltrônico tem GE
            Console.WriteLine($"O valor da garantia é de {eletronico.CalcularGarantiaEstendida()}");
            Console.WriteLine($"O valor da garantia de 2 anos é de {eletronico.CalcularGarantiaEstendida(2)}");
        }
    }
}
