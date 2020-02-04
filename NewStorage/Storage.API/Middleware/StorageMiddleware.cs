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
                await SendErrorMassege(httpContext, "BadReauest ", StatusCodes.Status400BadRequest);
            }
            catch (Exception exp)
            {
                await SendErrorMassege(httpContext, "Internal Server Error ", StatusCodes.Status500InternalServerError);
            }
        }

        private async Task SendErrorMassege(HttpContext httpContext, string message, int statusCode)
        {
            httpContext.Response.Clear();
            httpContext.Response.StatusCode = statusCode;

            await httpContext.Response.WriteAsync(message + statusCode);
        }
    }
}
