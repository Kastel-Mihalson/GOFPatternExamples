namespace ObserverPattern
{
    public interface IObservable<T>
    {
        void AddSubscriber(IObserver<T> observer);
        void RemoveSubscriber(IObserver<T> observer);
        void NotifySubscribers();
    }
}
