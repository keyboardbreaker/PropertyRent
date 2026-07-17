using PropertyRent.Application.Interfaces;
using PropertyRent.Domain.Entities;

namespace PropertyRent.Application.Services;

public class PropertyService
{
    private readonly IPropertyRepository _propertyRepository;

    public PropertyService(IPropertyRepository propertyRepository)
    {
        _propertyRepository = propertyRepository;
    }

    public void Create(Property property)
    {
        _propertyRepository.Add(property);
    }

    public IEnumerable<Property> GetAll()
    {
        return _propertyRepository.GetAll();
    }
}