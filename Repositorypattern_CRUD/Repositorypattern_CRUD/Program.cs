using BussinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Repoistorypattern_DTO.Dbcontact;
using System.Data.Entity;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IdatalayerInterface, DataLayerClass>();
builder.Services.AddTransient<IbussinessInterface, BussinessClass>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Dbcontext>(options =>
           options.UseSqlServer(builder.Configuration.GetConnectionString("DataConnection")));


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
