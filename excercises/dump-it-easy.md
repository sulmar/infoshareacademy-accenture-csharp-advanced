## DumpItEasy

## Wprowadzenie
Podczas developmentu przydaje się szybka diagnostyka stanu obiektu bez potrzeby uruchamiania Visual Studio.
Chociażby poprzez wyświetlenie bieżących wartości wskazanego obiektów na konsolę.

## Zadanie
Utwórz metodę `Dump()`, która umożliwi zrzucanie stanu dowolnego obiektu referecyjnego do formatu **Markdown** w formie tabeli.

## Przykład

- Definicja klasy
  
```csharp
using System;

public class Customer
{   
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime MemberSince { get; set; }
    
    public Customer(string name, int age, string email, string address, string phoneNumber, DateTime memberSince)
    {
        Name = name;
        Age = age;
        Email = email;
        Address = address;
        PhoneNumber = phoneNumber;
        MemberSince = memberSince;
    }   
}
```


- Użycie

```csharp
class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer(
            "John",
            "Smith",
            30,
            "john@example.com",
            "Dworcowa 1",
            "555-123-4567",
            new DateTime(2020, 01, 01));
						
	    customer.Dump();
    }
}


customer.Dump()
```

- Oczekiwany Rezultat:

| Property Name | Value       |
|---------------|-------------|
| FirstName     | John        |
| LastName      | Smith       |
| Age           | 30          |
| Email         | john@example.com |
| Address       | Dworcowa 1   |
| Phone Number  | 555-123-4567 |
| Member Since  | 2020-01-01   |


## Wymagania
1. Metoda powinna wyświetlać tylko właściwości publiczne
2. Tabela powinna być w formacie [Markdown](https://www.markdownguide.org/)
3. Dodaj możliwość wyboru formatu w przyszłości, np. JSON
4. Dodaj możliwość przekierowania rezultatu w inne miejsce docelowe niż konsola, np. baza danych, REST API


## Czas
- 45 min. 
