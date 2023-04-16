using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.Extensions.Primitives;

namespace Lesson42_OTUS_Middleware.Middlewares
{
    public class CustomHttpRedirectionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly int _securePort = 7254;
        public CustomHttpRedirectionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.IsHttps)
            {
                await _next(context);
                return;
            }

            var host = new HostString(context.Request.Host.Host, _securePort);

            var url = UriHelper.BuildAbsolute(
                    scheme: "https",
                    host,
                    context.Request.PathBase,
                    context.Request.Path,
                    context.Request.QueryString
            );

            context.Response.Headers["Location"] = new StringValues(url);
            context.Response.StatusCode = StatusCodes.Status307TemporaryRedirect;

        }

    }
}
