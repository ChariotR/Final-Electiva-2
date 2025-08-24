var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "🚀 Hola Mundo. Como andamos los mas duros de electiva.");

var port = Environment.GetEnvironmentVariable("PORT") ?? "3000";
app.Urls.Add($"http://*:{port}");

app.Run();  
