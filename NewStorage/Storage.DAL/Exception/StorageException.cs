using System;
using Json.Net;

namespace Storage.DAL.Exception
{
    public class StorageException : System.Exception
    {
        public int StatusCode { get; set; }

        public StorageException()
        {
        }

        public StorageException(int statusCode)
        {
            this.StatusCode = statusCode;
        }

        public StorageException(int statusCode, string message) : base(message)
        {
            this.StatusCode = statusCode;
        }


    }
}
