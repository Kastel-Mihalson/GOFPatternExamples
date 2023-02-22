namespace IteratorPattern
{
    public interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }
}