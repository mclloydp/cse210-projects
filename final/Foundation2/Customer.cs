using System;
using System.Collections.Generic;


class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string GetAddress()
    {
        return _address.GetFullAddress();
    }

    public string GetName()
    {
        return _name;
    }
}
