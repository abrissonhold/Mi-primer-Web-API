using Aplication.Interfaces;
using Aplication.UserCase.Students;
using Aplication.UserCase.Students.GetAll;
using Infraestucture.Command;
using Infraestucture.Persistence;
using Infraestucture.Query;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//custom
var connectionString = builder.Configuration["ConnectionString"];
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(connectionString));

builder.Services.AddScoped<IStudentServices, StudentServices>();
builder.Services.AddScoped<IStudentQuerys, StudentQuerys>();
builder.Services.AddScoped<IStudentCommand, StudentCommand>();

builder.Services.AddTransient<IServicesGetAll, ServicesGetAll>();

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
