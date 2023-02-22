namespace CommandPattern
{
    public class TestCommandPattern
    {
        public void Execute()
        {
            PersonCommandInvoker invoker = new PersonCommandInvoker();
            IUnit simplePerson = new SimplePerson();
            IUnit runnerPerson = new RunnerPerson();
            invoker.ExecuteCommand();
            invoker.SetCommand(new WalkCommand(simplePerson));
            invoker.ExecuteCommand();
            invoker.SetCommand(new AttackCommand(simplePerson));
            invoker.ExecuteCommand();

            Console.WriteLine();
            invoker.SetCommand(new WalkCommand(runnerPerson));
            invoker.ExecuteCommand();
            invoker.StopCommand();

            Console.WriteLine($"Текущая команда: {invoker.GetCurrentCommand().GetType().Name}");
            invoker.SetCommand(new AttackCommand(runnerPerson));
            invoker.ExecuteCommand();
            invoker.SetCommand(new JumpCommand(runnerPerson));
            invoker.ExecuteCommand();
            invoker.StopCommand();
        }
    }
}