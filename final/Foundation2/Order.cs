class Order
{
    Customer _customer;
    List<Product> _products;
    private int _productCost;
    private int _total;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void Add(Product product)
    {
        _products.Add(product);
        _productCost = Calculate();
        _total = Calculate();
    }
    public void DisplayAll()
    {
        _customer.Display();

        foreach (Product p in _products)
        {
            p.Display();
        }
        Console.WriteLine($"Product Total: ${_productCost}");
        Console.WriteLine($"Grand Total: ${Shipping(_customer.IsInUSA())}");
        Console.Write("Press Enter to move to next Order: ");
        Console.ReadLine();
    }
    public int Shipping(bool IsInUSA)
    {
        if(!IsInUSA)
        {
            return _total + 5;
        }
        else
        {
            return _total + 15;
        }
    }
    public void DisplayPackingLabel()
    {
        foreach (Product i in _products)
        {
            i.DisplayPacking();
        }
        Console.WriteLine($"Product Total: ${_productCost}");
    }
    public void DisplayShippingLabel()
    {
        _customer.Display();
    }
    private int Calculate()
    {
        int total = 0;
        foreach (Product i in _products)
        {
            int money = i.ItemCost(i.GetUnitPrice(), i.GetQuantity());
            total += money;
        }
        return total;
    }
}