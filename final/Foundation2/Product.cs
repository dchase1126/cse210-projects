class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    // constructor
    public Product(string productName, int productId, int quantity, double price)
    {
        this._productName = productName;
        this._productId = productId;
        this._quantity = quantity;
        this._price = price;
    }

    // Methods
    public string GetName() { return _productName; }
    public int GetProductId() { return _productId; }
    public double GetPrice() { return _price; }
    public int GetQuantity() { return _quantity; }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }

}