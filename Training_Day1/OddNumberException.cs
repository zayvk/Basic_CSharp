using System;
using System.Runtime.Serialization;

namespace Training_Day1
{
    [Serializable]
    internal class OddNumberException : Exception
    {
        public OddNumberException()
        {
        }

        public OddNumberException(string message) : base(message)
        {
        }

        public OddNumberException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected OddNumberException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}