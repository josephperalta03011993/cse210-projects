class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address; 
    }
    public bool IsInUSA()
    {
        return _address.InIsUSA();
    }

    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }

    public string GetCustomerName()
    {
        return _name;
    }
}