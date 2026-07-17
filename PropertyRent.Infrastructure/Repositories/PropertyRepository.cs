using PropertyRent.Application.Interfaces;
using PropertyRent.Domain.Entities;

namespace PropertyRent.Infrastructure.Repositories;

public class PropertyRepository : IPropertyRepository
{
    private readonly IList<Property> _properties = [];

    public void Add(Property property)
    {
        _properties.Add(property);
    }

    public Property? GetById(int id)
    {
        return _properties.FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<Property> GetAll()
    {
        return _properties;
    }
}