using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.ExercicioProduto.Models
{
    class Livro : Produto
    {
        //Propriedades
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public int AnoPublicacao { get; set; }

        //Construtor
        public Livro(int id, string nome, string autor) : base(id, nome) //id e nome já consta em produto "pai"
        {
            Autor = autor;
        }

        //Sobrescrever o método definido no "pai" (override), modificar o comportamento do método da classe filha
        public override decimal CalcularDesconto()
        {
            return CalcularDesconto(50);
        }

        // Sobrescrever o método desconto com cupom, adicionando o cupom FIAPBOOK com 30%

        public override decimal CalcularDesconto(string cupom)
        {
            //return cupom == "FIAPBOOK" ? CalcularDesconto(30) : cupom == "FIAP10" ? CalcularDesconto(10) : Preco;
            //base para referenciar o método 
            return cupom == "FIAPBOOK" ? CalcularDesconto(30) : base.CalcularDesconto(cupom);
        }


    }
}
