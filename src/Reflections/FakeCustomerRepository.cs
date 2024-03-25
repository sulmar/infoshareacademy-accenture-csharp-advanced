namespace Reflections;

interface ICustomerRepository
{
    Customer Get(int id);

}

internal class FakeCustomerRepository : ICustomerRepository
{
    public Customer Get(int id) => new()
    {
        Id = id
    };


}

