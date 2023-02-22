namespace ObserverPattern
{
    public class Bar : IObserver<WeatherTemperature>
    {
        private IObservable<WeatherTemperature> _observable;

        public void Subscribe(IObservable<WeatherTemperature> observable)
        {
            _observable = observable;
            _observable.AddSubscriber(this);
            Console.WriteLine($"-- Bar подписался на канал: --");
        }

        public void Update(WeatherTemperature observableObject)
        {
            Console.WriteLine($"New info about weather temperature:\n" +
                $"Temperature for Bar: {observableObject.Temp} temp.");
            Console.WriteLine(new string('-', 50));
        }

        public void Unsubscribe()
        {
            _observable.RemoveSubscriber(this);
            _observable = null;
            Console.WriteLine($"-- Bar отписался от канала --");
        }
    }
}
