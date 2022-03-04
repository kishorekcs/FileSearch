using System;
using System.Runtime.Serialization;

namespace FileSearch.Class
{
    [Serializable]
    internal class InvalidRootDescriptionException : Exception
    {
        public InvalidRootDescriptionException()
        {
        }

        public InvalidRootDescriptionException(string message) : base(message)
        {
        }

        public InvalidRootDescriptionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidRootDescriptionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}