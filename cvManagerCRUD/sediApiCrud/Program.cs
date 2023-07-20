using Microsoft.EntityFrameworkCore;
using sediApiCrud.model;
using sediApiCrud.model.Interfaces;
using System.Data.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// adding more services!

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// this is to add the string for the sql database
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetValue<string>("ConnectionString")));
// this is to add the interface and the class of the interface
builder.Services.AddTransient<IRepository, Repository>();

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
