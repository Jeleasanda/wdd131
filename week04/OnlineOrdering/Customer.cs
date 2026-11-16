public class Customer
{
    private readonly string _name;
    private readonly Address _address;

    public Customer(string name, Address address)
    {
        _name = name ?? string.Empty;
        _address = address ?? throw new System.ArgumentNullException(nameof(address));
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}
