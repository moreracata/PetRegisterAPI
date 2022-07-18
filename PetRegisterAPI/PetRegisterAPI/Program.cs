using Microsoft.EntityFrameworkCore;
using PetRegisterAPI.Repositories;
using Microsoft.Extensions.Configuration;
using PetRegisterAPI.Models;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);
var config = new ConfigurationBuilder()
      .AddJsonFile("appsettings.json", optional: false)
      .Build();

// Add services to the container.

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer();
builder.Services.AddResponseCaching();
builder.Services.AddScoped<IRepository, DataBaseRepository>();
builder.Services.AddDbContext<PetRegisterContext>(options => options.UseSqlServer(config.GetConnectionString("defaultConnection")));


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

app.UseAuthentication();

app.UseAuthorization();

app.UseResponseCaching();

app.MapControllers();

app.Run();
