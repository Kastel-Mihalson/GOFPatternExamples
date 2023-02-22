namespace DecoratorPatternV2
{
    public class SetCucumber : BurgerDecorator
    {
        public string IngredientName { get; set; } = "Желтый тверждый откусанный оугрец.";
        public SetCucumber(Burger bg) : base(bg.Name, bg)
        {
            Console.WriteLine("-> Добавлен оругчик.");
        }
        public override int GetPrice()
        {
            return burger.GetPrice() + 25;
        }

        public override List<string> GetIngredients()
        {
            var ing = burger.GetIngredients();
            ing.Add(IngredientName);

            return ing;
        }
    }
}