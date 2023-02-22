namespace BuilderPatternV2
{
    public abstract class CharacterBuilder
    {
        public abstract void SetTShirt();
        public abstract void SetPants();
        public abstract void SetShoes();
        public abstract Character GetResult();
    }
}