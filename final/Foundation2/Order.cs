using System.Reflection.Emit;

public class Order
{
    private Customer _customer;
    private List<Product> _products;
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
    public float CalcOrderPrice()
    {
        float price = 0;
        foreach (Product p in _products)
        {
            price += p.GetPriceTotal();
        }
        if (_customer.GetIsUSA())
        {
            price += 5;
        }
        else
        {
            price += 35;
        }
        return price;

    }
    public string CreatePackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} - {p.GetProductID()}\n";
        }
        return label;
    }
    public string CreateShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().DisplayAddress()}";
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"{_customer.GetName()}'s Order:");
        Console.WriteLine("==================================================");
        Console.WriteLine(CreatePackingLabel());
        Console.WriteLine(CreateShippingLabel());
        Console.WriteLine($"Total Cost: {CalcOrderPrice()}");
        Console.WriteLine("===================================================");
    }
}