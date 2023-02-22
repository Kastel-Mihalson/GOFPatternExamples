namespace DecoratorPatternV2
{
    public class TestDecoratorPatternV2
    {
        public void Execute()
        {
            Burger simpleBurger = new SimpleBurger();
            Console.WriteLine($"Стандартный бургер без добавок:\n{new string('-', 30)}");
            ShowInfo(simpleBurger);

            Console.WriteLine($"Бургер с добавками:\n{new string('-', 30)}");
            simpleBurger = new SetTomat(simpleBurger);
            simpleBurger = new SetCheese(simpleBurger);
            ShowInfo(simpleBurger);

            Console.WriteLine($"Бургер с добавками FULL SET:\n{new string('-', 30)}");
            simpleBurger = new SetBecon(simpleBurger);
            simpleBurger = new SetCucumber(simpleBurger);
            ShowInfo(simpleBurger);
        }

        private void ShowInfo(Burger burger)
        {
            Console.WriteLine("Ингредиенты:");
            foreach (var item in burger.GetIngredients())
            {
                Console.WriteLine(item);
            }
            if (burger.GetIngredients().Count == 0)
            {
                Console.WriteLine("-- Пусто -- ");
            }
            Console.WriteLine($"\nЦена бургера: {burger.GetPrice()}\n");
        }
    }
}