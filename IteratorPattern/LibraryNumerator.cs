namespace IteratorPattern
{
    public class LibraryNumerator : IBookIterator
    {
        private IBookNumerable _aggregate;
        private int _index = 0;

        public LibraryNumerator(IBookNumerable agg)
        {
            _aggregate = agg;
        }

        public bool HasNext()
        {
            return _index < _aggregate.Count;
        }

        public Book Next()
        {
            return _aggregate[_index++];
        }
    }
}