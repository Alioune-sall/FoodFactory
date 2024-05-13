namespace Factory.Lib
{
    internal class Meat : IFood
    {
        private string _name;
        private int _price;
        private DateOnly _expirationDate;
        public Meat()
        {
            this._name = "Meat";
            this._price = 3;
            this._expirationDate = new DateOnly(2024, 08, 09);
        }
        
        public int GetPrice()
        {
            return _price;
        }
        public string DisplayInfo()
        {
            return $" this is {_name}, the price is {_price} and the expiration date is {_expirationDate}";
        }
    }
}
