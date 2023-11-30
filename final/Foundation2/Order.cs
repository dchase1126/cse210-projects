class Order
{
    private List<Product> _products = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public double CalculateTotal()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            product.CalculatePrice();
            total += product.CalculatePrice();
        }

        if (_customer.GetUSA())
        {
            total += 5.00;
        }
        else
        {
            total += 35.00;
        }

        return total;
    }

    public void GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine("\nProduct Packing Label");
            Console.WriteLine($"Product Name: {product.GetName()}");
            Console.WriteLine($"Product ID: {product.GetProductId()}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("Customer Shipping Label\n");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().GetAddressString());
    }

    public void AddProduct()
    {
        Console.WriteLine("\nEnter order information below.\n");

        Console.WriteLine("Product Name ");
        string name = Console.ReadLine();

        Console.WriteLine("Product ID Number ");
        int productId = int.Parse(Console.ReadLine());

        Console.WriteLine("Product Price  ");
        double price = double.Parse(Console.ReadLine());

        Console.WriteLine("Product Quantity  ");
        int quantity = int.Parse(Console.ReadLine());

        Product product = new Product(name, productId, quantity, price);

        _products.Add(product);

    }
}