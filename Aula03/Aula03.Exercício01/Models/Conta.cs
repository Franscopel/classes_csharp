using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Exercício01.Models
{
    abstract class Conta
    {
        public decimal Saldo { get; protected set; }
        public double Numero { get; set; }

        public bool Depositar(decimal valor)
        {
            //validar se o valor de depósito é positivo
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            throw new Exception("Valor inválido"); //substituiu o: return false;
        }
    }

}
