using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure;


internal class InMemoryCustomerRepository : InMemoryEntityRepository<Customer>, ICustomerRepository
{
    public IEnumerable<Customer> GetByName(string name)
    {
        return entities.Values.Where(e=>e.Name == name);
    }
}

