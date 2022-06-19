// 1. conectando para usar el entity framework
using Microsoft.EntityFrameworkCore;
using Comenzando.DataAccess;

var builder = WebApplication.CreateBuilder(args);

//2. Conexion con sql Server Express
const string CONNECTIONNAME = "ComenzandoDB";
var connectionString = builder.Configuration.GetConnectionString(CONNECTIONNAME);

//3. Añadir contexto
builder.Services.AddDbContext<ComenzandoDBContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
