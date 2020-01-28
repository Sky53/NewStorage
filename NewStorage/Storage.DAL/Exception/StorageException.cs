using System;
using System.Collections.Generic;
using System.Text;

namespace Storage.DAL.Exception
{
    [Serializable]
    class StorageException : System.Exception // По какой-то магической причине иначе Exception он не видит
    {
        public StorageException()
        {

        }

        public StorageException(string code) : base(code)
        {

        }
    }
}
