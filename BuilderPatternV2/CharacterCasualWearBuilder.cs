namespace BuilderPatternV2
{
    public class CharacterCasualWearBuilder : CharacterBuilder
    {
        public Character Character = new Character();

        public override void SetPants()
        {
            Character.AddElement(new SimplePants());
        }

        public override void SetShoes()
        {
            Character.AddElement(new SimpleShoes());
        }

        public override void SetTShirt()
        {
            Character.AddElement(new SimpleTShirt());
        }

        public override Character GetResult()
        {
            return Character;
        }
    }
}