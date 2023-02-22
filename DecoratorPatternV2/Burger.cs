namespace DecoratorPatternV2
{
    public abstract class Burger
    {
        public string Name { get; set; }
        public Burger(string name)
        {
            Name = name;
        }
        public abstract int GetPrice();
        public abstract List<string> GetIngredients();
    }
}