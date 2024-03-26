using GenericTypes.Abstractions;
using GenericTypes.Infrastructure;
using GenericTypes.Model;

Console.WriteLine("Hello, Generic Types!");

 // GenericMethodTest();

GenericClassAndInterfaceTest();

void GenericClassAndInterfaceTest()
{
    ICustomerRepository customerRepository = new InMemoryCustomerRepository();

    var customer = new Customer { Id = 1, Name = "John Smith" };
    
    customerRepository.Add(customer);

    Console.WriteLine(customer);

    IOrderRepository orderRepository = new InMemoryOrderRepository();

    var order = new Order { Id = 1, Number = "001", Customer = customer };

    orderRepository.Add(order);
    
    Console.WriteLine(order);

    // TODO: Dodaj implementację
    IMeasureRepository measureRepository = null;

    throw new NotImplementedException();
}

static void GenericMethodTest()
{
    LocalStorage storage = new LocalStorage();
    storage.Set("counter", 10);
    storage.Set("token", "abc");
    storage.Set("loggedOn", DateTime.Now);


    var counter = storage.GetInt("counter");

    Console.WriteLine(++counter);
    Console.WriteLine(storage.Get("token"));
    Console.WriteLine(storage.GetDateTime("loggedOn"));
}
