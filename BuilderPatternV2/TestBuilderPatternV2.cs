namespace BuilderPatternV2
{
    public class TestBuilderPatternV2
    {
        public void Execute()
        {
            Creator characterCreator = new Creator();
            CharacterBuilder simpleCharacterBuilder = new CharacterCasualWearBuilder();
            Character simpleCharacter = characterCreator.CreateCharacter(simpleCharacterBuilder);
            Console.WriteLine("Simple charater elements:");
            foreach (var item in simpleCharacter.elements)
            {
                item.ShowInfo();
            }
            Console.WriteLine();
            CharacterBuilder redCharacterBuilder = new CharacterRedWearBuilder();
            Character redCharacter = characterCreator.CreateCharacter(redCharacterBuilder);
            Console.WriteLine("Red character elements:");
            foreach (var item in redCharacter.elements)
            {
                item.ShowInfo();
            }
        }
    }
}
