using GenericTypes.Model;

namespace GenericTypes.Abstractions;

interface ICustomerRepository
{
    Customer? Get(int id);
    IEnumerable<Customer> GetAll(int id);
    void Add(Customer customer);
    void Delete(int id);
}
