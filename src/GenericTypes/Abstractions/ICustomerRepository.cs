using GenericTypes.Model;

namespace GenericTypes.Abstractions;

interface ICustomerRepository : IEntityRepository<Customer>
{
    IEnumerable<Customer> GetByName(string name);
}
