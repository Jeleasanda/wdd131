using System;

public class Address
{
    private readonly string _street;
    private readonly string _city;
    private readonly string _state;
    private readonly string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street ?? string.Empty;
        _city = city ?? string.Empty;
        _state = state ?? string.Empty;
        _country = country ?? string.Empty;
    }

    public bool IsInUSA()
    {
        return string.Equals(_country.Trim(), "USA", StringComparison.OrdinalIgnoreCase)
            || string.Equals(_country.Trim(), "United States", StringComparison.OrdinalIgnoreCase)
            || string.Equals(_country.Trim(), "United States of America", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
