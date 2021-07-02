using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Exercício01.Models
{
    class ContaPoupanca
    {
        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public decimal Rendimentos { get; set; }

        //Métodos
        public bool Depositar(decimal valor)
        {
            //validar se o valor de depósito é positivo
            if(valor > 0)
            {
                Saldo += valor;
                return true;
            }
            return false;
        }

        public bool Retirar(decimal valor)
        {
            //validar se o saldo é suficiente
            if(Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
