using System;

namespace ObserverPattern
{
    public class Foo : IObserver<WeatherTemperature>
    {
        private IObservable<WeatherTemperature> _observable;

        public void Subscribe(IObservable<WeatherTemperature> observable)
        {
            _observable = observable;
            _observable.AddSubscriber(this);
            Console.WriteLine($"-- Foo подписался на канал: --");
        }

        public void Update(WeatherTemperature observableObject)
        {
            Console.WriteLine($"Поступило новая информация о температуре:\n" +
                $"Данные погоды для Foo: {observableObject.Temp} градусов.");
            Console.WriteLine(new string('-', 50));
        }

        public void Unsubscribe()
        {
            _observable.RemoveSubscriber(this);
            _observable = null;
            Console.WriteLine($"-- Foo отписался от канала --");
        }
    }
}
