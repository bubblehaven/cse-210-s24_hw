using System.Dynamic;

public class Product
{
    private string _name;
    private int _quantity;
    private string _productID;
    private float _price;
    public Product(string name, int quantity, string productID, float price)
    {
        _name = name;
        _quantity = quantity;
        _price = price;
        _productID = productID;

    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }
    public float GetPriceTotal()
    {
        return _price * _quantity;
    }

}