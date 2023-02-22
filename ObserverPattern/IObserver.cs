namespace ObserverPattern
{
    public interface IObserver<T>
    {
        void Update(T observableObject);
    }
}
