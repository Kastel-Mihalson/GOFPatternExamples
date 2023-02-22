namespace BuilderPatternV3
{
    public class NormBurgerBuilder : Builder
    {
        public Burger Burger = new Burger();
        public override Burger GetResult()
        {
            return Burger;
        }

        public override void SetBecon()
        {
            Console.WriteLine("Нормальная котлета из свинины.");
        }

        public override void SetCheese()
        {
            Console.WriteLine("Сыр какой то");
        }

        public override void SetCucumbers()
        {
            Console.WriteLine("Свежий огурец.");
        }

        public override void SetOnion()
        {
            Console.WriteLine("Фиолетовый лук.");
        }

        public override void SetTomato()
        {
            Console.WriteLine("Томан домашний.");
        }
    }
}