namespace DecoratorPatternV2
{
    public class SetTomat : BurgerDecorator
    {
        public string IngredientName { get; set; } = "Томат домашний.";
        public SetTomat(Burger bg) : base(bg.Name, bg)
        {
            Console.WriteLine("-> Добавлен томат.");
        }
        public override int GetPrice()
        {
            return burger.GetPrice() + 20;
        }

        public override List<string> GetIngredients()
        {
            var ing = burger.GetIngredients();
            ing.Add(IngredientName);

            return ing;
        }
    }
}