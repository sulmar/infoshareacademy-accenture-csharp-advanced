
using Reflections;
using Reflections.Abstractions;
using Reflections.Infrastructure;
using System.Text.Json;

Console.WriteLine("Hello, Reflection!");

// MetadataTest();

IoCTest();

void IoCTest()
{
    IProductRepository productRepository = ProductRepositoryFactory.Create("CsvFile");

    var product = productRepository.Get(1);
    productRepository.Add(product);
    Console.WriteLine(product);

}

void MetadataTest()
{
    DocumentationGenerator.GenerateDocumentation(typeof(Order));
}

ActivatorTest();

GetSetValueTest();

AttributeTest();



PluginLibraryTest();

void AttributeTest()
{
    Product product = new Product(1, "Smartphone", "Black", 499.99m, Product.Category.Electronics);

    // TODO: Get Image Path from attribute

    throw new NotImplementedException(); 
    
    string imagePath = "";    

    Console.WriteLine($"Render icon from: {imagePath}");

    
}

static void GetSetValueTest()
{

    string json = @"{
    ""HasWebsite"": true,
    ""IsPeselValid"": true
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
         customer[property.Name] = true;

        Console.WriteLine(customer[property.Name]);

    }

    Console.WriteLine(customer);
}


static void ActivatorTest()
{
    Printer3D printer = new Printer3D();

    printer.MoveLeft(3);
    printer.MoveRight(2);
    printer.MoveUp(1);
    printer.MoveDown(4);

    string[] operations = ["MoveLeft", "MoveRight", "MoveUp", "MoveDown"];

    int distance = 3;

    Queue<ICommand> commands = new Queue<ICommand>();
    commands.Enqueue(new MoveLeftCommand(printer, distance));
    commands.Enqueue(new MoveLeftCommand(printer, distance));
    commands.Enqueue(new MoveRightCommand(printer, distance));

    while(commands.Count > 0)
    {
        ICommand command = commands.Dequeue();

        command.Execute();
    }


    foreach (string operation in operations)
    {
        // TODO: execute operation
    }



}


static void PluginLibraryTest()
{
    // TODO: Load PluginLibrary assembly and call DoWork()

    throw new NotImplementedException();
}
