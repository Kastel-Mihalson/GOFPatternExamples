namespace BuilderPatternV3
{
    public class SomeOtherBurgerBuilder : FluentBuilder
    {
        public Burger Burger = new Burger();

        public override Burger GetResult()
        {
            return Burger;
        }

        public override FluentBuilder SetBecon()
        {
            Console.WriteLine("Топ Бекон.");
            return this;
        }

        public override FluentBuilder SetCheese()
        {
            Console.WriteLine("Топ сыр.");
            return this;
        }

        public override FluentBuilder SetCucumber()
        {
            Console.WriteLine("Топ Оругчики.");
            return this;
        }

        public override FluentBuilder SetOnion()
        {
            Console.WriteLine("Топ лук.");
            return this;
        }

        public override FluentBuilder SetTomato()
        {
            Console.WriteLine("Топ томат.");
            return this;
        }
    }
}
