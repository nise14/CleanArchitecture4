using Contoso.Builders;
using Contoso.Presenters;
using Contoso.Repository.Dapper;
using Contoso.Repository.EFCore;
using Contoso.Videos.UseCases;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDapperRepository();
builder.Services.AddEFCoreRepository(builder.Configuration);
builder.Services.AddPresenters();
builder.Services.AddBuilders();
builder.Services.AddVideoUseCases();

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
