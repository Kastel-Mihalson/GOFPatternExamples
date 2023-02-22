namespace PrototypePattern
{
    public class TestPrototypePattern
    {
        public void Execute()
        {
            Console.WriteLine("Clone instance:");
            IPrototype first = new SomePrototype("Some first");
            first.GetInfo();
            IPrototype second = first.Clone();
            second.GetInfo();

            Console.WriteLine("\nMClone instance:");
            IPrototype third = first.MClone();
            third.GetInfo();

            Console.WriteLine("\nDeep clone instance:");
            IPrototype fourth = first.DeepClone() as SomePrototype;
            fourth.GetInfo();

        }
    }
}
