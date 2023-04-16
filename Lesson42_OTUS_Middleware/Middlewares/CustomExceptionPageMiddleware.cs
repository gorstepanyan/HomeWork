namespace Lesson42_OTUS_Middleware.Middlewares
{
    public class CustomExceptionPageMiddleware
    {
        private readonly RequestDelegate _next;
        public CustomExceptionPageMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                var html = $"<html><div style='color:red'>{ex.StackTrace ?? ex.Message}</div></html>";
                httpContext.Response.ContentType = "text/html";
                await httpContext.Response.WriteAsync(html);
            }
        }

    }
}
