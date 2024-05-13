namespace Factory.Lib;
internal class Fruit : IFood
{
    private string _name;
    private int _price;
    private DateOnly _expirationDate;
    public Fruit()
    {
        this._name = "Banana";  
        this._price = 5;
        this._expirationDate = new DateOnly (2025, 04, 04);
    }

    public int GetPrice() { return _price; }
    public string GetName() { return this._name; }
    public string DisplayInfo()
    {
        return $" this is {_name}, the price is {_price} and the expiration date is {_expirationDate}";
    }
}