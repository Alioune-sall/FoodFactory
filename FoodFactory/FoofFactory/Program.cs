using Factory.Lib;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                var food1 = FoodFactory.Create("Banana");
                Console.WriteLine(food1.DisplayInfo());

                var food2 = FoodFactory.Create("Meat");
                Console.WriteLine(food2.DisplayInfo());

                var food3 = FoodFactory.Create("chickpeas");
                Console.WriteLine(food3.DisplayInfo());


                var cart1 = new ShoppingCart();
                cart1.AddItem(food1);
                cart1.AddItem(food2);
                cart1.AddItem(food3);
                Console.WriteLine("The total cost is " + cart1.CalculateTotal());


                var food4 = FoodFactory.Create("arancia");
            }
            catch (FoodNotFoundException e)
            {
                Console.WriteLine(e.Name + "'s not present in factory");
            }
        }
    }
}
