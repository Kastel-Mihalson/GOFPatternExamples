namespace CommandPattern
{
    public class JumpCommand : ICommand
    {
        private IUnit _unit;

        public JumpCommand(IUnit unit)
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
            _unit.Jump();
        }
    }
}