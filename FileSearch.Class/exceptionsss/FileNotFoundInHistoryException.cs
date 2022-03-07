using System;
using System.Runtime.Serialization;

namespace FileSearch.Class
{
    [Serializable]
    internal class FileNotFoundInHistoryException : Exception
    {
        public FileNotFoundInHistoryException()
        {
        }

        public FileNotFoundInHistoryException(string message) : base(message)
        {
        }

        public FileNotFoundInHistoryException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FileNotFoundInHistoryException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}