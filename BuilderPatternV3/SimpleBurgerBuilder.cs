namespace BuilderPatternV3
{
    public class SimpleBurgerBuilder : Builder
    {
        public Burger Burger = new Burger();

        public override Burger GetResult()
        {
            return Burger;
        }

        public override void SetBecon()
        {
            Console.WriteLine("Котлета с курицей.");
        }

        public override void SetCheese()
        {
            Console.WriteLine("Сыр Дишманский.");
        }

        public override void SetCucumbers()
        {
            
        }

        public override void SetOnion()
        {
            
        }

        public override void SetTomato()
        {
            
        }
    }
}