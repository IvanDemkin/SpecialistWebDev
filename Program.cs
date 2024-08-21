namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(
                new WebApplicationOptions() { Args = args});
            var app = builder.Build();

            app.UseStaticFiles();
            
            app.Map("/date", test =>
            {
                test.Run(async (context) =>
                {
                    await context.Response.WriteAsync($"Server date: {DateTime.Now.ToShortDateString()}");
                });
            });

            app.Map("/time", test =>
             {
                 test.Run(async (context) =>
                 {
                     await context.Response.WriteAsync($"Server time: {DateTime.Now.ToShortTimeString()}");
                 });
             });
             
            app.Run(async context =>
            {
                context.Response.Redirect("/NotFound.html");
                await context.Response.WriteAsync("");

            });

            app.Run();
        }
    }
}
