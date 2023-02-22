namespace CommandPattern
{
    public class WalkCommand : ICommand
    {
        private IUnit _unit;

        public WalkCommand(IUnit unit)
        {
            Console.WriteLine("Персонаж: " + unit.GetType().Name);
            _unit = unit;
        }

        public void Cancel()
        {
            _unit.Wait();
        }

        public void Execute()
        {
            _unit.Walk();
        }
    }
}