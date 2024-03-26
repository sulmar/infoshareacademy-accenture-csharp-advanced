using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GenericTypes.Model;

abstract class Base
{
    
}

abstract class BaseEntity : Base
{
    public int Id { get; set; }
}

class Customer : BaseEntity
{
    public string Name { get; set; }
    public override string ToString()
    {
        return $"Customer: {{ Id = {Id}, Name = {Name} }}";
    }
}
