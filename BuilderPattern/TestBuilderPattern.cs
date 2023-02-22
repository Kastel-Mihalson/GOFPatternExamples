namespace BuilderPattern
{
    public class TestBuilderPattern
    {
        public void Execute()
        {
            Barista barista = new Barista();
            CoffeeBuilder blackCoffeeBuilder = new BlackCoffee();
            Coffee blackCoffee = barista.MakeCoffee(blackCoffeeBuilder);
            Console.WriteLine($"Black Coffee:\n" +
                $"Sugar: {blackCoffee.Sugar}\n" +
                $"Milk: {blackCoffee.Milk}\n" +
                $"Aromatizator: {blackCoffee.Aromatizator}\n");

            Console.WriteLine();
            CoffeeBuilder capuchinoBuilder = new Capuchino();
            Coffee capuchino = barista.MakeCoffee(capuchinoBuilder);
            Console.WriteLine($"Capuchino:\n" +
                $"Sugar: {capuchino.Sugar}\n" +
                $"Milk: {capuchino.Milk}\n" +
                $"Aromatizator: {capuchino.Aromatizator}\n");
        }
    }
}
