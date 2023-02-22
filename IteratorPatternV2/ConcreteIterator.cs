namespace IteratorPatternV2
{
    public class ConcreteIterator<T> : IIterator<T>
    {
        private IAggregate<T> _aggregate;
        private long _current;
        public ConcreteIterator(IAggregate<T> agg)
        {
            _aggregate = agg;
            _current = 0;
        }

        public virtual T CurrentItem()
        {
            if (!IsDone())
            {
                return _aggregate.GetItem(_current);
            }
            else
            {
                throw new NotImplementedException("Error");
            }
        }

        public virtual void First()
        {
            _current = 0;
        }

        public virtual bool IsDone()
        {
            return _current >= _aggregate.Count();
        }

        public virtual void Next()
        {
            _current++;
        }
    }
}