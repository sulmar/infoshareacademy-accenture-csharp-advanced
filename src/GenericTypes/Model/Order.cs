namespace GenericTypes.Model;

class Order
{
    public int Id { get; set; }
    public string Number { get; set; }
    public Customer Customer { get; set; }

    public override string ToString()
    {
        return $"Order: {{ Id = {Id}, Number = {Number}, Customer = {Customer} }}";
    }
}
