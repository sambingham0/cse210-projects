public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private string _packingLabel;
    private string _shippingLabel;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        // Add shipping cost
        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        _packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            _packingLabel += $"{product.GetName()} - {product.GetProductId()}\n";
        }
        return _packingLabel;
    }

    public string GetShippingLabel()
    {
        _shippingLabel = "Shipping Label:\n";
        _shippingLabel += $"{_customer.GetName()}\n{_customer.GetAddress().GetAddressString()}";
        return _shippingLabel;
    }
}