internal class FoodNotFoundException : Exception
{
    public string Name { get; }
    public FoodNotFoundException(string name)
    {
        Name = name;
    }
}

