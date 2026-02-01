var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from Sample API B!");
app.MapGet("/health", () => Results.Ok());

app.Run();
