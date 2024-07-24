using System.Net.Sockets;

class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address adress)
    {
        _name = name;
        _address = adress;
    }
    public bool IsInUSA()
    {
        if (!_address.IsInUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Display()
    {
        Console.Write($"{_name}, ");
        _address.Display();
    }
}