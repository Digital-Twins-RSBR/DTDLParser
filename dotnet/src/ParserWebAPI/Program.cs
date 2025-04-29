
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.OpenApi.Models;
using ParserWebAPI.models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddDbContext<DTDLModelContext>(opt => opt.UseInMemoryDatabase("DTDLModels"));
builder.Services.AddDbContext<DTDLSpecificationContext>(opt => opt.UseInMemoryDatabase("DTDLSpecifications"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => 
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "DTDL Parser API", Version = "v1" });
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
        c.IncludeXmlComments(xmlPath);
        c.EnableAnnotations();
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
