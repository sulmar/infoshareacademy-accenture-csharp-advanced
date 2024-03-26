using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure;

internal class InMemoryOrderRepository : InMemoryEntityRepository<Order>, IOrderRepository
{
  
}
