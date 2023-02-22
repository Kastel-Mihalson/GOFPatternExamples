namespace BuilderPatternV2
{

    public class Character
    {
        public List<IElement> elements = new List<IElement>();

        public void AddElement(IElement element)
        {
            elements.Add(element);
        }
    }
}