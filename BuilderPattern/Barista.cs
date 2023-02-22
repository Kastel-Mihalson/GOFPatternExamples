namespace BuilderPattern
{
    public class Barista
    {
        public Coffee MakeCoffee(CoffeeBuilder builder)
        {
            builder.CreateCoffee();
            builder.AddSugar();
            builder.AddMilk();
            builder.AddAromatizator();
            return builder.Coffee;
        }
    }
}