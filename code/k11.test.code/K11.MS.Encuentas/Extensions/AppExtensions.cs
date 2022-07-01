using K11.MS.Encuentas.Middlewares;
using Microsoft.AspNetCore.Builder;

namespace K11.MS.Encuentas.Extensions
{
    public static class AppExtensions
    {
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}
