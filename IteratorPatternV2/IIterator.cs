namespace IteratorPatternV2
{
    /// <summary>
    /// Интерфейс итератора для перебола элементов класса
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IIterator<T>
    {
        void First();
        void Next();
        T CurrentItem();
        bool IsDone();
    }
}