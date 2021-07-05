using System;
using System.Collections.Generic;
using System.Text;

namespace Aula03.Exercício01.Models
{
    class Cliente
    {
        public String Nome { get; set; }
        public String Cpf { get; set; }
        public String Telefone { get; set; }

        //construtores não tem retorno - mesmo nome da classe
        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome; //propriedade = parâmetro
            Cpf = cpf;
            Telefone = telefone;
        }


    }
}
