namespace BuilderPatternV3
{
    public class Creator
    {
        public Builder Builder { get; set; }
        public Creator(Builder builder)
        {
            Builder = builder;
        }
        public void Build()
        {
            Builder.SetCheese();
            Builder.SetOnion();
            Builder.SetTomato();
            Builder.SetCucumbers();
            Builder.SetBecon();
        }
    }
}