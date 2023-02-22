namespace IteratorPatternV2
{
    /// <summary>
    /// Интрефейс типа, который будем перебирать
    /// </summary>
    /// <typeparam name="T">Перебираемый класс</typeparam>
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
        long Count();
        T GetItem(long index);
    }
}