namespace ObserverPattern
{
    public class TestObserverPattern
    {
        public void Execute()
        {
            var observable = new Weather("Погода Ачаки");
            var observerFoo = new Foo();
            var observerBar = new Bar();

            observerFoo.Subscribe(observable);
            observerBar.Subscribe(observable);

            observable.TrackTemperature();
        }
    }
}
