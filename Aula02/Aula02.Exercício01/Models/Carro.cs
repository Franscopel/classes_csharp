using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.Exercicio01.Models
{
    class Carro : Veiculo
    {
        //Propriedades
        public double Comprimento { get; set; }
        public string Placa { get; set; }
        public bool ArCondicionado { get; set; }
    }
}
