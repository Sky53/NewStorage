using Microsoft.AspNetCore.Builder;

namespace Storage.API.Middleware
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<StorageMiddleware>();
        }
    }
}
