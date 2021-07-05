using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.Exemplo01.Models
{
    class Carro
    {

        //Propriedades
        public string Modelo { get; set; }
        public int Ano { get; set; }

        //Construtores - > Sem retorno e mesmo nome da classe
        public Carro(string modelo)
        {
            Modelo = modelo;
        }

        public Carro(string modelo, int ano) //mesmo nome da classe
        {
            Modelo = modelo;
            Ano = ano;
        }


    }
}
