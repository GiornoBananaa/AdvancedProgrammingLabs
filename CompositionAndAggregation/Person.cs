namespace CompositionAndAggregation;

public class Person
{
    private string _name;
    private string _age;
    private string _gender;
    private Address _address;

    public Person(string name, string age, string gender, Address address)
    {
        _name = name;
        _age = age;
        _gender = gender;
        _address = address;
    }

    public void ChangeAddress(Address newAddress)
    {
        _address = newAddress;
    }
}

public class Address
{
    private string _street;
    private string _city;
    private string _country;

    public Address(string street, string city, string country)
    {
        _street = street;
        _city = city;
        _country = country;
    }
}