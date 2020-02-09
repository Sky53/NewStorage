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
                await SendErrorResponse(httpContext, exp.Message, StatusCodes.Status400BadRequest);
            }
            catch (Exception exp)
            {
                await SendErrorResponse(httpContext, exp.Message, StatusCodes.Status500InternalServerError);
            }
        }

        private async Task SendErrorResponse(HttpContext httpContext, string message, int statusCode)
        {
            httpContext.Response.Clear();
            httpContext.Response.StatusCode = statusCode;

            await httpContext.Response.WriteAsync(message);
        }
    }
}
