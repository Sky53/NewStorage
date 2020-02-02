using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
                httpContext.Response.Clear();
                httpContext.Response.StatusCode = 400;

                await httpContext.Response.WriteAsync(httpContext.Response.StatusCode.ToString());
            }
            catch (Exception exp)
            {
                httpContext.Response.Clear();
                httpContext.Response.StatusCode = 500;

                await httpContext.Response.WriteAsync(httpContext.Response.StatusCode.ToString());
            }
            return;
        }
    }

    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<StorageMiddleware>();
        }
    }
}
