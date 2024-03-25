using ExtensionMethods;

Console.WriteLine("Hello, Extension Methods!");

DateTimeExtensionsTest();

IntMethodExtensionsTest();

InterfaceExtensionsTest();

void IntMethodExtensionsTest()
{
    int number1 = 5;
    int number2 = 10;

    Console.WriteLine($"{number1} is {(number1 % 2 == 0 ? "even" : "odd")}."); // Output: 5 is odd.
    Console.WriteLine($"{number2} is {(number2 % 2 != 0 ? "even" : "odd")}."); // Output: 10 is even.
}


static void InterfaceExtensionsTest()
{
    List<int> numbers = [1, 2, 3, 4, 5];

    foreach (int item in numbers)
    {
        Console.WriteLine(item);
    }

    IEnumerable<string> words = ["apple", "banana", "cherry"];

    foreach (string item in words)
    {
        Console.WriteLine(item);
    }

    List<Customer> customers =
    [
        new Customer { Id = 1, Name = "Alice" },
        new Customer { Id = 2, Name = "Bob" },
        new Customer { Id = 3, Name = "Charlie" }
    ];

    foreach (Customer item in customers)
    {
        Console.WriteLine(item);
    }
}

static void DateTimeExtensionsTest()
{
    DateTime now = DateTime.Now;
    long unixTimestamp = Helper.ToUnixTimestamp(now);

    Console.WriteLine($"Current DateTime: {now}");
    Console.WriteLine($"Unix Timestamp: {unixTimestamp}");

    DateTime convertedDateTime = Helper.FromUnixTimestamp(unixTimestamp);
    Console.WriteLine($"Converted DateTime: {convertedDateTime}");
   
}

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Customer: {{ Id = {Id}, Name = {Name} }}";
    }
}
