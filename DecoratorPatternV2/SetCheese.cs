namespace DecoratorPatternV2
{
    public class SetCheese : BurgerDecorator
    {
        public string IngredientName { get; set; } = "Сыр с плесенью.";
        public SetCheese(Burger bg) : base(bg.Name, bg)
        {
            Console.WriteLine("-> Добавлен сыр.");
        }
        public override int GetPrice()
        {
            return burger.GetPrice() + 35;
        }

        public override List<string> GetIngredients()
        {
            var ing = burger.GetIngredients();
            ing.Add(IngredientName);

            return ing;
        }
    }
}