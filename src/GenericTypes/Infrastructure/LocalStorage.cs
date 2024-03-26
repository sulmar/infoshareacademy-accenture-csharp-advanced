namespace GenericTypes.Infrastructure;

internal class LocalStorage
{
    private readonly IDictionary<string, string> _storage = new Dictionary<string, string>();

    public void Set<T>(string key, T value)
    {
        _storage.TryAdd(key, value.ToString());
    }

    public T? Get<T>(string key)
    {
        if (_storage.TryGetValue(key, out var value))
            return (T)Convert.ChangeType(value, typeof(T));
        else
            return default;
    }

   
}
