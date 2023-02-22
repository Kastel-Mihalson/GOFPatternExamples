namespace BuilderPatternV3
{
    public abstract class FluentBuilder
    {
        public abstract FluentBuilder SetCheese();
        public abstract FluentBuilder SetOnion();
        public abstract FluentBuilder SetTomato();
        public abstract FluentBuilder SetCucumber();
        public abstract FluentBuilder SetBecon();
        public abstract Burger GetResult();
    }
}
