using Microsoft.AspNetCore.Mvc.Filters;

namespace Storage.API.Filter
{
    public class StorageExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
