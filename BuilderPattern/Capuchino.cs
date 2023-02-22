namespace BuilderPattern
{
    public class Capuchino : CoffeeBuilder
    {
        public override void AddAromatizator()
        {
            Coffee.Aromatizator = 4f;
        }

        public override void AddMilk()
        {
            Coffee.Milk = 4f;
        }

        public override void AddSugar()
        {
            Coffee.Sugar = 2f;
        }
    }
}