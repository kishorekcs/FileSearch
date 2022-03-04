using System;
using System.Runtime.Serialization;

namespace FileSearch.Class
{
    [Serializable]
    internal class InvalidFinderChoiceException : Exception
    {
        public InvalidFinderChoiceException()
        {
        }

        public InvalidFinderChoiceException(string message) : base(message)
        {
        }

        public InvalidFinderChoiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidFinderChoiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}