 namespace WebApplication1
{
    public class SecondMiddleware
    {
        private RequestDelegate _next;
        public SecondMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //await context.Response.WriteAsync($"Status code = {context.Response.StatusCode}");
            context.Response.Redirect("/NotFound.html");
            //await _next(context);
        }
    }
}
