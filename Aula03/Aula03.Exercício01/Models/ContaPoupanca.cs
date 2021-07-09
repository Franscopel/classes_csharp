using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Exercício01.Models
{
    class ContaPoupanca : Conta, IcontaInvestimento
    {
        public decimal Rendimentos { get; set; }


        //construtor
        public ContaPoupanca(double numero)
        {
            Numero = numero;
        }


        //Métodos
       
        public bool Retirar(decimal valor)
        {
            //validar se o saldo é suficiente
            if(Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            throw new Exception("Saldo insuficiente"); //substituiu o: return false;
        }

        public decimal CalcularRetornoInvestimento(decimal taxa)
        {
            return Saldo * taxa;
        }
    }
}
