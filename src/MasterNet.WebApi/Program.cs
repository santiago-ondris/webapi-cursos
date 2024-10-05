var builder = WebApplication.CreateBuilder(args);

// Agrega servicios al contenedor.
builder.Services.AddControllers(); //Se agregan todos los controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) //Se ejecuta a nivel local (desarrollo)
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();
