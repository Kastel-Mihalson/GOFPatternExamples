namespace BuilderPatternV3
{
    public abstract class Builder
    {
        public abstract void SetCheese();
        public abstract void SetTomato();
        public abstract void SetOnion();
        public abstract void SetBecon();
        public abstract void SetCucumbers();
        public abstract Burger GetResult();
    }
}