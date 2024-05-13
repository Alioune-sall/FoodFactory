namespace Factory.Lib
{
    internal class ShoppingCart
    {
        List<IFood> foods = new();

        public void AddItem(IFood item)
        {
            foods.Add(item);
        }

        public void RemoveItem(IFood item) 
        {
            foods.Remove(item);
        }

        public int CalculateTotal()
        {
            int total = 0;
            foreach( var item in foods)
            {
                total += item.GetPrice();
            }

            return total;
        }

    }
}
