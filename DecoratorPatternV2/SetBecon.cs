namespace DecoratorPatternV2
{
    public class SetBecon : BurgerDecorator
    {
        public string IngredientName { get; set; } = "Крысиный бекон.";

        public SetBecon(Burger bg) : base(bg.Name, bg)
        {
            Console.WriteLine("-> Добавлен бекон.");
        }
        public override int GetPrice()
        {
            return burger.GetPrice() + 40;
        }

        public override List<string> GetIngredients()
        {
            var ing = burger.GetIngredients();
            ing.Add(IngredientName);

            return ing;
        }
    }
}