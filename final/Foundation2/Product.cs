public class Product
{
    private string _name;
    private int _itemID;
    private float _unitPrice;
    private int _quantity;

    public Product(string name, int itemID, float unitPrice, int quantity)
    {
        _name = name;
        _itemID = itemID;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }
    public int GetID()
    {
        return _itemID;
    }
    public int GetQuantity()
    {
        return _quantity;
    }

    public float TotalItemCost()
    {
        return _quantity * _unitPrice;
    }
}