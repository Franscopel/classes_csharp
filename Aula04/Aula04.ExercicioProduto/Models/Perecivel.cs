using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.ExercicioProduto.Models
{
    class Perecivel : Produto
    {
        //Propiedades
        public DateTime DataValidade { get; set; }


        //Construtor
        public Perecivel(int id, string nome, DateTime dataValidade) : base(id, nome)
        {
            DataValidade = dataValidade;
        }
    }
}
