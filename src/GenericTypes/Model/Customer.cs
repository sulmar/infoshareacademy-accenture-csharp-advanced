using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericTypes.Model;

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public override string ToString()
    {
        return $"Customer: {{ Id = {Id}, Name = {Name} }}";
    }
}
