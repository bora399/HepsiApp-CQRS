using HepsiApp.Persistence;
using HepsiApp.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using HepsiApp.Application;
using HepsiApp.Mapper;
using HepsiApp.Application.Exceptions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer(); // Swagger için gerekli
builder.Services.AddSwaggerGen(); // Swagger'ý ekle

builder.Services.AddPersistence(builder.Configuration);
builder.Services.AddApplication();
builder.Services.AddCustomMapper();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.ConfigureExceptionHandlingMiddleware(); 
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
