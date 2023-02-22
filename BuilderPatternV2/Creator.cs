namespace BuilderPatternV2
{
    public class Creator
    {
        public Character CreateCharacter(CharacterBuilder builder)
        {
            builder.SetTShirt();
            builder.SetPants();
            builder.SetShoes();
            return builder.GetResult();
        }
    }
}