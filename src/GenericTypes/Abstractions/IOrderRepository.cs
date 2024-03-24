using GenericTypes.Model;

namespace GenericTypes.Abstractions;

interface IOrderRepository
{
    Order? Get(int id);
    IEnumerable<Order> GetAll(int id);
    void Add(Order customer);
    void Delete(int id);
}