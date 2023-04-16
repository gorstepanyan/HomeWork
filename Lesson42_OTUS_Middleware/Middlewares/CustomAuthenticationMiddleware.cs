using System.Security.Claims;

namespace Lesson42_OTUS_Middleware.Middlewares
{
    public class CustomAuthenticationMiddleware
    {
        private RequestDelegate _next;
        public CustomAuthenticationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            var queryParams = context.Request.Query;

            var claims = queryParams.Select(param => new Claim(param.Key, param.Value.ToString())).ToList();
            if (claims.Any())
            {
                context.User = new ClaimsPrincipal(
                new ClaimsIdentity(claims, "cookie")
                );

            }
            else
            {
                context.User = new ClaimsPrincipal(
                new ClaimsIdentity(claims)
                );

            }





            await _next(context);
        }
    }
}
