using System;
using System.Collections.Generic;
using System.Text;

namespace Aula05.Exemplo.Models
{

    //Classe abstrata -> não pode ser instanciada e pode definir métodos abstratos (sem implementaçao)
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        //Métodos
        public abstract void CadastrarEndereco(string endereco);

        public void InformarNome()
        {
            Console.WriteLine("Informe o nome");
            Nome = Console.ReadLine();
        }
    }
}
