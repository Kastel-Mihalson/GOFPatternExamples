namespace BuilderPattern
{
    public abstract class CoffeeBuilder
    {
        public Coffee Coffee { get; set; }

        public void CreateCoffee()
        {
            Coffee = new Coffee();
        }
        public abstract void AddSugar();
        public abstract void AddMilk();
        public abstract void AddAromatizator();
    }
}