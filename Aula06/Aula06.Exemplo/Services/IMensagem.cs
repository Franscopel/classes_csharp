using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06.Exemplo.Services
{
    //Define o contrato, os métodos que a classe deve implementar
    interface IMensagem
    {
        void EnviarMensagem(string mensagem);
    }
}
