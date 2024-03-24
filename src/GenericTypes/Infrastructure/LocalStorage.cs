namespace GenericTypes.Infrastructure;

// TODO: refactor this
internal class LocalStorage
{
    private readonly IDictionary<string, string> _storage = new Dictionary<string, string>();

    public void Set(string key, string value)
    {
        _storage.TryAdd(key, value);
    }

    public string? Get(string key)
    {
        if (_storage.TryGetValue(key, out var value))
            return value;
        else
            return default;
    }

    public void Set(string key, int value)
    {
        _storage.TryAdd(key, value.ToString());
    }

    public int? GetInt(string key)
    {
        if (_storage.TryGetValue(key, out var value))
            return (int)Convert.ChangeType(value, typeof(int));
        else
            return default;
    }

    public void Set(string key, DateTime value)
    {
        _storage.TryAdd(key, value.ToString());
    }

    public DateTime? GetDateTime(string key)
    {
        if (_storage.TryGetValue(key, out var value))
            return (DateTime)Convert.ChangeType(value, typeof(DateTime));
        else
            return default;
    }
}
