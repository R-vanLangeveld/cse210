using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 S Main", "Anyplace", "AnyState", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Pencil", "P-103", 3.59, 10);
        Product product2 = new Product("Pen", "Pn-1703", 6.99, 5);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.PackingLabel();
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.TotalPrice());

        Console.WriteLine("");

        Address address2 = new Address("2693 S Maple Street", "AnyCity", "AnyProvince", "Canada");
        Customer customer2 = new Customer("John Jones", address2);
        Order order2 = new Order(customer2);
        Product product3 = new Product("Syrup", "S-203", 35.59, 10);
        Product product4 = new Product("Ham", "H-163", 25.99, 2);
        Product product5 = new Product("Ketchup Potato Chips", "K-1952", 2.95, 5);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.PackingLabel();
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.TotalPrice());
    }
}