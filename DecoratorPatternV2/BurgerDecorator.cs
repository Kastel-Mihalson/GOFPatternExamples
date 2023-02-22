namespace DecoratorPatternV2
{
    public abstract class BurgerDecorator : Burger
    {
        protected Burger burger;
        protected BurgerDecorator(string name, Burger burger) : base(name)
        {
            this.burger = burger;
        }
    }
}