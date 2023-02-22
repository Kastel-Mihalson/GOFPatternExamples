namespace CommandPattern
{
    public class AttackCommand : ICommand
    {
        private IUnit _unit;

        public AttackCommand(IUnit unit)
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
            _unit.Attack();
        }
    }
}