class Order
{
    private Customer customer;
    private List<Product> products;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }
        decimal shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += $"Product: {product.GetName()}, ID: {product.GetProductId()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Customer Name: {customer.GetName()}\nAddress:\n{customer.GetAddress().GetFullAddress()}";
    }
}