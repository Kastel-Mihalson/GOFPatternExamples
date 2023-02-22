namespace ObserverPattern
{
    public class Weather : IObservable<WeatherTemperature>
    {
        private List<IObserver<WeatherTemperature>> _observers;
        private WeatherTemperature _weatherTemperature;
        public string Name { get; set; }

        public Weather(string name)
        {
            _observers = new List<IObserver<WeatherTemperature>>();
            _weatherTemperature = new WeatherTemperature();
            Name = name;
        }

        public void AddSubscriber(IObserver<WeatherTemperature> observer)
        {
            _observers.Add(observer);
        }

        public void NotifySubscribers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_weatherTemperature);
            }
        }

        public void RemoveSubscriber(IObserver<WeatherTemperature> observer)
        {
            _observers.Remove(observer);
        }

        public void TrackTemperature()
        {
            var rand = new Random();

            while(true)
            {
                var temp = rand.Next(-20, 20);
                Console.WriteLine($">>> Weather temperature resource: {Name}. Current temp: {temp}");
                Console.WriteLine(new string('-', 50));
                _weatherTemperature.Temp = temp;
                NotifySubscribers();
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.Clear();
            }
        }
    }
}
