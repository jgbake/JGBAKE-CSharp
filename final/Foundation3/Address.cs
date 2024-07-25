public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _zipCode;
    private string _country;

    public Address(string streetAddress, string city, string stateOrProvince, string zipCode, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _zipCode = zipCode;
        _country = country;
    }

    public string FullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}, {_zipCode}\n{_country}";
    }
}