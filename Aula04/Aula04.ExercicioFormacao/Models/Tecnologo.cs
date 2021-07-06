using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.ExercicioFormacao.Models
{
    class Tecnologo : Formacao
    {
        //Propriedades
        public bool PlanoEstendido { get; set; }

        //Construtor
        public Tecnologo(string nome) : base(nome) //nome já consta em Formacao "pai"
        {
        }

        //Método
        public override decimal CalcularMensalidade()
        {
            return Mensalidade = Duracao * 500;
        }
        protected override void DefinirDuracao()
        {
            Duracao = 24;
        }
    }
}
