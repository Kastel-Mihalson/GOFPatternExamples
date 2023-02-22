namespace CommandPattern
{
    public class WaitCommand : ICommand
    {
        private IUnit _unit;

        public WaitCommand(IUnit unit)
        {
            Console.WriteLine("Персонаж: " + unit.GetType().Name);
            _unit = unit;
        }

        public void Cancel() { }

        public void Execute()
        {
            _unit.Wait();
        }
    }
}