using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        Product pro1 = new Product("gold bar", "AU12", 250, 3);
        Product pro2 = new Product("sunglasses", "SN34", 6, 2);
        Product pro3 = new Product("Trash Can", "TR40", 13, 6);
        Address _address = new Address("2389 sundrive way", "SD", "CA", "USA");
        Address address2 = new Address("2400 lefthold ave", "Town", "Onterio", "CA");
        Customer customer1 = new Customer("Kevin mcalistar", _address);
        Customer customer2 = new Customer("Bob Lenzington", address2);
        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        order1.Add(pro1);
        order1.Add(pro2);
        order1.Add(pro3);
        order2.Add(pro3);
        order2.Add(pro1);
        order2.Add(pro2);
        orders.Add(order1);
        orders.Add(order2);
        int _response = 0;
        while (_response != 4)
        {
            Console.Clear();
            Console.WriteLine("1. Show packing Labels\n2. Show Shipping Labels\n3. Show full order\n4. Quit");
            _response = int.Parse(Console.ReadLine());
            switch (_response)
            {
                case 1:
                    foreach (Order o in orders)
                    {
                        o.DisplayPackingLabel();
                        Console.Write("\n Press Enter to Continue: ");
                        Console.ReadLine();
                    }
                    break;
                case 2:
                    foreach (Order o in orders)
                    {
                        o.DisplayShippingLabel();
                        Console.Write("\n Press Enter to Continue: ");
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    foreach (Order o in orders)
                    {
                        o.DisplayAll();
                    }
                    break;
            }
        }
    }
}