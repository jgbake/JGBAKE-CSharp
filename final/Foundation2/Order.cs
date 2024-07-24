public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public float TotalOrderCost()
    {
        float tempTotal = 0;

        foreach (Product product in _products)
        {
            tempTotal += product.TotalItemCost();
        }

        if (_customer.IsInUSA() == true)
        {
            tempTotal += 5;
        }
        else
        {
            tempTotal += 35;
        }

        return tempTotal;
    }
    public string PackingLabel()
    {
        string toReturn = "------------------------\n\x1b[1mItems:\x1b[0m\n";

        foreach (Product product in _products)
        {
            toReturn += $"{product.GetQuantity()}x {product.GetName()} - {product.GetID()}\n";
        }

        toReturn += "------------------------";
        return toReturn;
    }
    public string ShippingLabel()
    {
        return $"Name: {_customer.GetName()}\nAddress:\n{_customer.GetAddress()}";
    }
}