using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Exercício01.Models
{
    class ContaCorrente
    {
        public decimal Saldo { get; private set; }
        public double Numero { get; set; }
        public bool Especial { get; set; }
        public decimal Limite { get; set; }
        public Cliente Cliente { get; set; }
        public ContaPoupanca ContaPoupanca { get; set; }
        public double Juros { get; set; }

        //Construtor

        public ContaCorrente(Cliente clieten, ContaPoupanca poupanca, double numero, bool especial)
        {
            Cliente = Cliente;
            ContaPoupanca = poupanca;
            Numero = numero;
            Especial = especial;
        }

        //Métodos
        public bool Depositar(decimal valor)
        {
            //validar se o valor de depósito é positivo
            if (valor > 0)
            {
                Saldo += valor;
                return true;
            }
            return false;
        }
        public bool Retirar(decimal valor)
        {
            //Valida se a conta é especial
            if (Especial) //variável já declarada como booleana, não precisa ser (Especial == true) 
            {
                if (valor <= Saldo + Limite)
                {
                    Saldo -= valor;
                    return true;
                }
            }
            else
            {
                if (valor <= Saldo)
                {
                    Saldo -= valor;
                    return true;
                }

            }
            return false;
        }
        /*if ((Especial && valor <= Saldo + Limite) || (!Especial && valor <= Saldo))
         {
            Saldo -= valor;
            return true;
        }
        return false;*/
        public decimal RetornarSaldoTotal()
        {
            //Ternário (Condição ? Se verdadeiro : Se falso)
            return Especial ? Saldo + Limite : Saldo;
            /*
             if (Especial)
                return Saldo + Limite;
            else
                return Saldo/
             */
        }
        public bool TransferirParaPoupanca(decimal valor)
        {
            //Retirar da conta corrente, se conseguir adicionar na poupanca
            //Chama o método Retirar da c/c e valida se foi possível
            if (Retirar(valor))
            {
                //Depositar na conta poupança
                ContaPoupanca.Depositar(valor);
                return true;
            }
            return false; 
        }
        public decimal CalcularTaxaJuros(int dias)
        {
            //valida se a conta está negativa
            //Converter um double em decimal, para ser possível a multiplicação por decimal

            //return Saldo < 0 ? dias * Convert.ToDecimal(Juros) * Saldo * -1 : 0;
            if (Saldo < 0)
                return dias * Convert.ToDecimal(Juros) * Saldo * -1;
            return 0;
        }   
    }
}
