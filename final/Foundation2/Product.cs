class Product
{
    private string _name;
    private string _ID;
    private int _pricePerUnit;
    private int _quantity;
    private int _itemCost;
    public Product(string name, string ID, int unitPrice, int quantity)
    {
        _name = name;
        _ID = ID;
        _pricePerUnit = unitPrice;
        _quantity = quantity;
        _itemCost = ItemCost(_pricePerUnit, _quantity);
    }
    public int ItemCost(int unit, int quantity)
    {
        return unit * quantity;
    }
    public int GetUnitPrice()
    {
        return _pricePerUnit;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public void Display()
    {
        Console.WriteLine($"{_name}: {_ID}  ${_pricePerUnit} * {_quantity}: ${_itemCost}");
    }
    public void DisplayPacking()
    {
        Console.WriteLine($"{_name}: {_ID}");
    }

}