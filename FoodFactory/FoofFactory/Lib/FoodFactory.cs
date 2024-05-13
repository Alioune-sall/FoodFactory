using Factory.Lib;


internal class FoodFactory
{
    public static IFood Create(string name) => name switch
    {
        "Meat" => new Meat(),
        "chickpeas" => new Vegetables(),
        "Banana" => new Fruit(),
        _ => throw new FoodNotFoundException(name)
    };
}

