class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public float CalculateTotalCost()
    {
        float totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        float shippingCost = _customer.IsInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID:{product.GetProductId()})\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return _customer.GetFullAddress();
    }

    public string GetCustomerName()
    {
        return _customer.GetCustomerName();
    }
}