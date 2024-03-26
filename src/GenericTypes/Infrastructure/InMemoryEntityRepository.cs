using GenericTypes.Abstractions;
using GenericTypes.Model;

namespace GenericTypes.Infrastructure;

internal class InMemoryEntityRepository<T> : IEntityRepository<T>
    where T : BaseEntity
{
    protected readonly IDictionary<int, T> entities = new Dictionary<int, T>();

    public void Add(T entity)
    {
        entities[entity.Id] = entity;
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public T? Get(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        throw new NotImplementedException();
    }
}
