using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06.Exemplo.Services
{
    //Classe implementa a interface
    class SmsMensagem : IMensagem
    {
        public void EnviarMensagem(string mensagem)
        {
            //Validação se a mensagem tem menos de 10 caracteres e lançar a MensagemInvalidaException
            if (mensagem.Length < 10)
                throw new MensagemInvalidaException("Mensagem com menos de 10 caracteres");
            Console.WriteLine($"Enviando um sms: { mensagem}");
        }
    }
}
