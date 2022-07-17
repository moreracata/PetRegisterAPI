using Microsoft.EntityFrameworkCore;
using PetRegisterAPI.Repositories;
using Microsoft.Extensions.Configuration;
using PetRegisterAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var config = new ConfigurationBuilder()
      .AddJsonFile("appsettings.json", optional: false)
      .Build();
// Add services to the container.
builder.Services.AddTransient<IRepository, DataBaseRepository>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
