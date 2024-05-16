using ItemsService.Helpers;
using ItemsService.ItemServiceCore.Entities.ItemTypes;
using ItemsService.ItemServiceCore.RepositoryContracts;
using ItemsService.ItemsServiceInfrastructure.Data.DatabaseContext;
using ItemsService.ItemsServiceInfrastructure.Data.Seeders;
using ItemsService.ItemsServiceInfrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.MapControllers();

try
{
    using var scope = app.Services.CreateScope();
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ItemsDbContext>();
    var itemsSeeder = new ItemsSeeder(context, new JsonFileReader());
    await itemsSeeder.Seed<Weapon>("WeaponsSeeder.json");
    await itemsSeeder.Seed<Armor>("ArmorSeeder.json");
}
catch (Exception e)
{
    Console.WriteLine("Insertion of data failed. Error: " +  e);
    throw;
}


app.Run();