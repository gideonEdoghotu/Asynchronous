var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/yes", async context =>
    {
        await context.Response.WriteAsync("Hello Worlssd");
    });
});

app.Run();