class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string TotalPrice()
    {
        double price = 0;
        foreach (Product i in _products)
        {
            price += i.TotalCost();
        }
        if (_customer.IsInUSA() == true)
        {
            price += 5;
        }
        else
        {
            price += 35.00;
        }
        return $"${Math.Round(price,2)}";
    }
    public void PackingLabel()
    {
        Console.WriteLine("Product List");
        foreach (Product i in _products)
        {
            Console.WriteLine($"{i.GetProductName()} {i.GetProductID()}");
        }
    }
    public string ShippingLabel()
    {
        Console.WriteLine("\nShipping Label");
        return $"{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}