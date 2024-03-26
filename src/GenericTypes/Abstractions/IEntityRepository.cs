namespace GenericTypes.Abstractions;

// Interfejs generyczny (ugólniony)
// Szablon interfejsu
interface IEntityRepository<T, TKey>
{
    T? Get(TKey id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Delete(TKey id);
}

interface IEntityRepository<T> : IEntityRepository<T, int>
{

}
