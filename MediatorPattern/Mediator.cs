namespace MediatorPattern
{
    public abstract class Mediator
    {
        public abstract void Send(Colleague colleague, string message);
    }

    public abstract class Colleague
    {
        private Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            _mediator.Send(this, message);
        }

        public abstract void Notify(string message);
    }

    public class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение заказчику: " + message);
        }
    }

    public class ProgrammerColleague : Colleague
    {
        public ProgrammerColleague(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение программисту: " + message);
        }
    }

    public class TesterColleague : Colleague
    {
        public TesterColleague(Mediator mediator) : base(mediator) { }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение тестеру: " + message);
        }
    }

    public class MediatorManager : Mediator
    {
        public Colleague Customer { get; set; }
        public Colleague Programmer { get; set; }
        public Colleague Tester { get; set; }

        public override void Send(Colleague colleague, string message)
        {
            switch (colleague)
            {
                case Colleague col when col == Customer:
                    Programmer.Notify(message);
                    break;
                case Colleague col when col == Programmer:
                    Tester.Notify(message);
                    break;
                case Colleague col when col == Tester:
                    Customer.Notify(message);
                    break;
                default:
                    break;
            }
        }
    }

    public class TestMediatorPattern
    {
        public void Execute()
        {
            var mediator = new MediatorManager();
            var customer = new CustomerColleague(mediator);
            var programmer = new ProgrammerColleague(mediator);
            var tester = new TesterColleague(mediator);

            mediator.Customer = customer;
            mediator.Programmer = programmer;
            mediator.Tester = tester;

            customer.Send("Есть новая задача. Нужно приступить к реализации.");
            programmer.Send("Задача реализована. Необходимо протестировать.");
            tester.Send("Задача протестирована. Можно двигать в релиз.");

            Console.ReadLine();
        }
    }
}