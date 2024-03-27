
public class Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime MemberSince { get; set; }

    public Customer(string firstName, string lastName, int age, string email, string address, string phoneNumber, DateTime memberSince)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Email = email;
        Address = address;
        PhoneNumber = phoneNumber;
        MemberSince = memberSince;
    }
}
