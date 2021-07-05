using Aula04.ExemploHeranca.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula04.ExemploHeranca02.Models
{
    public class Professor: Pessoa
    {
        //Propriedade
        public string MateriaLecionada { get; set; }

        //Construtor 
        public Professor(string nome) : base(nome)
        {
   
        }

        //Método
        public void FazerChamada()
        {
            Console.WriteLine($"{Nome} está fazendo chamada");
        }
    }
}
