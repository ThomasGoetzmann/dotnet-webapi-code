using BPAPI.Domain.Todos;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// required later for swagger usage
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ITodoRepository, InMemoryTodoDatabase>();
builder.Services.AddTransient<ITodoService, TodoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    // Use swagger and scalar (you can decide to use only one, or none if you want)
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapScalarApiReference();
}

app.UseAuthorization();

app.MapControllers();

app.Run();