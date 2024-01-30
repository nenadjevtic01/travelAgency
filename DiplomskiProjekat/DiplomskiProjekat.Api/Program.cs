using DiplomskiProjekat.Api.Core;
using DiplomskiProjekat.Api.Extensions;
using DiplomskiProjekat.Application.Loggers;
using DiplomskiProjekat.Application.UseCases;
using DiplomskiProjekat.Application.UseCases.Commands;
using DiplomskiProjekat.Implementation;
using DiplomskiProjekat.Implementation.Loggers;
using DiplomskiProjekat.Implementation.UseCases.Commands;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var settings = new AppSettings();
builder.Configuration.Bind(settings);
builder.Services.AddSingleton(settings);
builder.Services.AddApplicationUser();
builder.Services.AddJwt(settings);
builder.Services.AddDiplomskiProjekatContext();
builder.Services.AddUseCases();
builder.Services.AddValidators();


builder.Services.AddTransient<IUseCaseLogger, UseCaseLogger>();
builder.Services.AddTransient<IExceptionLogger,ConsoleLogger>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddCors();

builder.Services.AddTransient<UseCaseHandler>();


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


app.MapControllers();

app.Run();
