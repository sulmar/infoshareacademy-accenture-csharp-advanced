using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure;

internal class InMemoryOrderRepository : IOrderRepository
{
    private readonly IDictionary<int, Order> orders = new Dictionary<int, Order>();

    public void Add(Order order)
    {
        orders[order.Id] = order;
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Order? Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Order> GetAll(int id)
    {
        throw new NotImplementedException();
    }
}