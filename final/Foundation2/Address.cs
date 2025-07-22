public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _isUSA;
    public Address(string streetAddress,string city,string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        if (country == "USA")
        {
            _isUSA = true;
        }
        else
        {
            _isUSA = false;
        }
    }
    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public bool GetIsUSA()
    {
        return _isUSA;
    }
    public string DisplayAddress()
    {
        return $"{_streetAddress}\n{_city}, {_state}, {_country}";
    }
}