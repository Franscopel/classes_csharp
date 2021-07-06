using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.ExercicioFormacao.Models
{
    class Instituicao
    {
        //Propriedades
        public string Nome { get; set; }

        //Construtor
        public Instituicao(string nome)
        {
            Nome = nome;
        }
    }
}
