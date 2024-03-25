namespace Reflections;

internal class Customer
{
    public int Id { get; set; }
    public bool IsRegonValid { get; set; }
    public bool IsPeselValid { get; set; }
    public bool HasWebsite { get; set; }    

    public override string ToString()
    {
        return $"Customer: {{ Id = {Id}, IsRegonValid = {IsRegonValid}, IsPeselValid = {IsPeselValid}, HasWebsite = {HasWebsite} }}";
    }

}
