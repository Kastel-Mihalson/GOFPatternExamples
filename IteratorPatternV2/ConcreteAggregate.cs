namespace IteratorPatternV2
{
    /// <summary>
    /// Конкретный класс, объекты которого будем перебирать
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ConcreteAggregate<T> : IAggregate<T>
    {
        private T[] _array = null;

        public ConcreteAggregate() { }

        public ConcreteAggregate(T[] array)
        {
            _array = array;
        }

        public long Count()
        {
            return _array.Length;
        }

        public IIterator<T> CreateIterator()
        {
            return new ConcreteIterator<T>(this);
        }

        public T GetItem(long index)
        {
            if ((index >= 0) && (index < _array.Length))
            {
                return _array[index];
            } 
            else
            {
                throw new NotImplementedException("Error! Bad index");
            }
        }
    }
}