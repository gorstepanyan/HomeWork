using System.Net;

namespace Lesson42_OTUS_Middleware.Middlewares
{
    public class CustomAuthorizationMiddleware
    {
        private RequestDelegate _next;
        public CustomAuthorizationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var endpoint = context.GetEndpoint();
            if (endpoint == null)
            {
                await _next(context);
                return;
            }

            if (endpoint.DisplayName?.ToLowerInvariant().Contains("restricted") == false)
            {
                await _next(context);
                return;
            }

            var identity = context.User.Identity;
            if (identity is null || !identity.IsAuthenticated)
            {
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                await context.Response.WriteAsync("Not authenticated");
                return;
            }

            var role = context.User.Claims.FirstOrDefault(claim => claim.Type == "role");
            if (role?.Value != "admin")
            {
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                await context.Response.WriteAsync("Not authorized");
                return;
            }


            await _next(context);


        }

    }
}
