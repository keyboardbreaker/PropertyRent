using Microsoft.Extensions.DependencyInjection;
using PropertyRent.Application.Interfaces;
using PropertyRent.Application.Services;
using PropertyRent.Domain.Entities;
using PropertyRent.Infrastructure.Repositories;

var services = new ServiceCollection();

services.AddSingleton<IPropertyRepository, PropertyRepository>();

services.AddSingleton<PropertyService>();

var provider = services.BuildServiceProvider();

var service = provider.GetRequiredService<PropertyService>();

service.Create(new Property
{
    Id = 1,
    Address = "generic street address",
    MonthlyRent = 2500,
    IsOccupied = true,
});

var properties = service.GetAll();

foreach (var property in properties)
{
    Console.WriteLine($"{property.Address} - £{property.MonthlyRent}");
}

var expensiveProperties = properties
    .Where(p => p.MonthlyRent > 2000)
    .OrderByDescending(p => p.MonthlyRent);

foreach (var property in expensiveProperties)
{
    Console.WriteLine(property.Address);
}