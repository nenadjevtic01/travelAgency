using DiplomskiProjekat.Api.Core;
using DiplomskiProjekat.Api.Extensions;
using DiplomskiProjekat.Implementation;

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