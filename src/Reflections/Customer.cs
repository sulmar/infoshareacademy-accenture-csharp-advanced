namespace Reflections;

internal class Customer
{
    public int Id { get; set; }
    public bool IsRegonValid { get; set; }
    public bool IsPeselValid { get; set; }
    public bool HasWebsite { get; set; }

    private bool _isRemoved;

    public override string ToString()
    {
        return $"Customer: {{ Id = {Id}, IsRegonValid = {IsRegonValid}, IsPeselValid = {IsPeselValid}, HasWebsite = {HasWebsite} }}";
    }

    public object this[string propertyName]
    {
        get => this.GetType().GetProperty(propertyName).GetValue(this);
        set => this.GetType().GetProperty(propertyName).SetValue(this, value);
    }

}
