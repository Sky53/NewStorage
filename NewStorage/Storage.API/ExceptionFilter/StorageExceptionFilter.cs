using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Storage.DAL.Exception;

namespace Storage.API.ExceptionFilter
{
    public class StorageExceptionFilter : IExceptionFilter
    {

        public void OnException(ExceptionContext context)
        {
            if(context.Exception is StorageException a)
            {
             //   throw new BadRequestResult();
                
            }
        //    var exp =  context.Exception .GetType();
        }
    }
}
