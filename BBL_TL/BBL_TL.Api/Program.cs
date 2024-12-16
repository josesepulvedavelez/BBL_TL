using BBL_TL.Core.Interfaces;
using BBL_TL.Infra;
using BBL_TL.Infra.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BblContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("cadena")));

builder.Services.AddScoped<IIncidenteRepo, IncidenteRepo>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

