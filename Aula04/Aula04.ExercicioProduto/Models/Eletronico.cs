﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.ExercicioProduto.Models
{
    class Eletronico : Produto
    {
        //Propriedades
        public bool Garantia { get; set; }

        //Construtor

        public Eletronico(int id, string nome) : base(id, nome) { }

        //Método
        public decimal CalcularGarantiaEstendida()
        {
            if (!Garantia)
                return 0;
            return Preco * 0.1m;
            //return Preco * 10 / 100;
            //return !Garantia ? 0 : Preco * 0.1m; //m no final do número par ser um decimal
        }

        //Sobrescrever o método CalcularGarantiaEstendida()
        public decimal CalcularGarantiaEstendida(int anos)
        {
            //if (!Garantia)
            //    return 0;
            //return Preco * 0.1m * anos;
            return CalcularGarantiaEstendida() * anos;
        }
    }
}
