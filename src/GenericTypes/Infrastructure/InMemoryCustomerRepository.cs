using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure;

internal class InMemoryCustomerRepository : ICustomerRepository
{
    private readonly IDictionary<int, Customer> customers = new Dictionary<int, Customer>();

    public Customer? Get(int id)
    {
        if (customers.TryGetValue(id, out Customer? customer))
            return customer;
        else
            return default;
    }

    public IEnumerable<Customer> GetAll(int id)
    {
        return customers.Values;
    }

    public void Add(Customer customer)
    {
        customers.Add(customer.Id, customer);
    }

    public void Delete(int id)
    {
        customers.Remove(id);
    }
}
