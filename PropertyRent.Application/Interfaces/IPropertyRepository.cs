using PropertyRent.Domain.Entities;

namespace PropertyRent.Application.Interfaces;

public interface IPropertyRepository
{
    void Add (Property property);
    Property? GetById(int propertyId);
    IEnumerable<Property> GetAll();
}