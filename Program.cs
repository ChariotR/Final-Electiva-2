var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "🚀 Hola Mundo desde DevOps CI/CD con C#");

app.Run();
