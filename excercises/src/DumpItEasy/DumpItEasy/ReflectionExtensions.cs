namespace DumpItEasy;

public static class ReflectionExtensions
{
    public static Dictionary<string, object?> GetPropertiesWithValues<T>(this T obj) => typeof(T).GetProperties()
                   .ToDictionary(p => p.Name, p => p.GetValue(obj));
}

