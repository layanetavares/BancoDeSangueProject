var builder = WebApplication.CreateBuilder(args);

// Configuração do CORS para liberar a comunicação com o Blazor WASM
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowBlazorOrigin", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

app.UseRouting();

// Aplicação da política CORS (deve vir antes de UseAuthorization e MapControllers)
app.UseCors("AllowBlazorOrigin");

app.UseAuthorization();

app.MapControllers();

app.Run();