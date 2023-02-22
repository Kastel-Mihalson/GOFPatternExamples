namespace CommandPattern
{
    public class PersonCommandInvoker
    {
        private ICommand _command;

        public PersonCommandInvoker() { }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            if (_command == null)
            {
                Console.WriteLine("Команда не задана.");
                return;
            }
            Console.Write("Выполнение команды: ");
            _command.Execute();
        }

        public void StopCommand()
        {
            if (_command == null)
            {
                Console.WriteLine("Команда не задана.");
                return;
            }
            Console.Write("Прекращение выполнения команды: ");
            _command.Cancel();
        }

        public ICommand GetCurrentCommand()
        {
            return _command;
        }
    }
}