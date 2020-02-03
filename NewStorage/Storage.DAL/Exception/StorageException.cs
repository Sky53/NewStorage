
namespace Storage.DAL.Exception
{
    public class StorageException : System.Exception
    {
        public StorageException()
        {
        }

        public StorageException(string message) : base(message)
        {
        }
    }
}
