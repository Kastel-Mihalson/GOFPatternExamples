namespace DecoratorPatternV2
{
    public class SimpleBurger : Burger
    {

        public SimpleBurger() : base ("Бюджетный бургер.") { }

        public override List<string> GetIngredients()
        {
            return new List<string>();
        }

        public override int GetPrice()
        {
            return 100;
        }
    }
}