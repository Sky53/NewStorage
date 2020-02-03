using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Storage.DAL.Exception;

namespace Storage.API.Middleware
{
    public class StorageMiddleware
    {
        private readonly RequestDelegate _next;

        public StorageMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (StorageException exp)
            {
                await HandleException(httpContext, exp, StatusCodes.Status400BadRequest);
            }
            catch (Exception exp)
            {
                await HandleException(httpContext, exp, StatusCodes.Status500InternalServerError);
            }
        }

        private async Task HandleException(HttpContext httpContext, Exception exp, int statusCode)
        {
            httpContext.Response.Clear();
            httpContext.Response.StatusCode = statusCode;
            if (statusCode == 400)
            {
                await httpContext.Response.WriteAsync(exp.Message);
            }
            else
            {
                await httpContext.Response.WriteAsync("Internal Server Error");
            }
        }
    }
}
