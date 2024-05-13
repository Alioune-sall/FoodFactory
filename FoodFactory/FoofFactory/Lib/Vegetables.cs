namespace Factory.Lib;
internal class Vegetables : IFood
{
    private string _name;
    private int _price;
    private DateOnly _expirationDate;
    public Vegetables()
    {
        this._name = "chickpeas";  //Ceci
        this._price = 2;
        this._expirationDate = new DateOnly(2026, 01, 12);
    }

    public int GetPrice() { return _price; }
    public string DisplayInfo()
    {
        return $" this is {_name}, the price is {_price} and the expiration date is {_expirationDate}";
    }
}