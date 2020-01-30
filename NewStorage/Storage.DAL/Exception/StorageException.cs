using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.DAL.Exception
{
    public class StorageException : System.Exception
    {
        public StorageException()
        {

        }

        public StorageException(string code) : base(code)
        {

        }
    }
}
