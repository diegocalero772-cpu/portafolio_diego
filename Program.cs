var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Abre wwwroot/index.html al entrar a "/"
app.UseDefaultFiles();

// Permite usar los archivos de wwwroot (css, imágenes)
app.UseStaticFiles();

app.Run();
