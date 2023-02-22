namespace IteratorPattern
{
    public class Library : IBookNumerable
    {
        private Book[] books;

        public Library()
        {
            books = new Book[]
            {
                new Book { Name = "Чистая архитектура" },
                new Book { Name = "Шаблоны проектирования" },
                new Book { Name = "Программирования для чайников" },
            };
        }

        public int Count
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get { return books[index]; }
        }

        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }
    }
}