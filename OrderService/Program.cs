var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// Configurer les routes de niveau supérieur
app.MapControllers();

app.Run("http://*:80"); // Ajoutez cette ligne pour spécifier le port 80
