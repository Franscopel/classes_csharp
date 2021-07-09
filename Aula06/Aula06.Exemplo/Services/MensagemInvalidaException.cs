using System;
using System.Runtime.Serialization;

namespace Aula06.Exemplo.Services
{
    [Serializable]
    internal class MensagemInvalidaException : Exception
    {
        public MensagemInvalidaException()
        {
        }

        public MensagemInvalidaException(string message) : base(message)
        {
        }

        public MensagemInvalidaException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MensagemInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}