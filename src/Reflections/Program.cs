
using Reflections;
using System.Text.Json;

Console.WriteLine("Hello, Reflection!");

GetSetValueTest();

static void GetSetValueTest()
{
    
    string json = @"{
    ""HasWebsite"": true
}";

    string patchRequest = $@"PATCH /api/customers/1 HTTP/1.1
Host: example.org
Content-Type: application/merge-patch+json

{json}";

    Console.WriteLine(patchRequest);

    ICustomerRepository fakeCustomerRepository = new FakeCustomerRepository();

    var customer = fakeCustomerRepository.Get(1);

    JsonDocument jsonDocument = JsonDocument.Parse(json);

    foreach (JsonProperty property in jsonDocument.RootElement.EnumerateObject())
    {
        Console.WriteLine($"Property Name: {property.Name} Value: {property.Value.GetBoolean()}");

        // TODO: Set property value like in JS
        // customer["HasWebsite"] = true;

    }

    Console.WriteLine(customer);
}

