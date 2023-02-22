namespace BuilderPatternV3
{
    public class TestBuilderPatternV3
    {
        public void Execute()
        {
            Console.WriteLine("Simple Burger:");
            Builder simpleBurgerBuilder = new SimpleBurgerBuilder();
            Creator creator = new Creator(simpleBurgerBuilder);
            creator.Build();

            Console.WriteLine();
            Console.WriteLine("Norm Burger:");
            Builder normBurgerBuilder = new NormBurgerBuilder();
            creator = new Creator(normBurgerBuilder);
            creator.Build();

            Console.WriteLine();
            Console.WriteLine("Burger with FluentBuilder:");
            FluentBuilder flBuilder = new SomeOtherBurgerBuilder();
            Burger burger = flBuilder.SetCheese()
                .SetTomato()
                .GetResult();
        }
    }
}