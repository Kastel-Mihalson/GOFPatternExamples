namespace BuilderPattern
{
    public class BlackCoffee : CoffeeBuilder
    {
        public override void AddAromatizator()
        {
            Coffee.Aromatizator = 2f;
        }

        public override void AddMilk()
        {
            
        }

        public override void AddSugar()
        {
            Coffee.Sugar = 2f;
        }
    }
}