namespace DecoratorPatternV2
{
    public class MajorBurger : Burger
    {
        public MajorBurger() : base("Мажорский бургер.") { }

        public override List<string> GetIngredients()
        {
            return new List<string>();
        }

        public override int GetPrice()
        {
            return 300;
        }
    }
}