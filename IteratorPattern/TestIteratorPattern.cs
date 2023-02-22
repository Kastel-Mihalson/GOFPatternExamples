namespace IteratorPattern
{
    public class TestIteratorPattern
    {
        public void Execute()
        {
            Console.WriteLine("Тест паттерна Итератор:");
            Library library = new Library();

            IBookIterator iterator = library.CreateNumerator();
            Console.WriteLine($"Названия книг в библиотеке:\n{new string('-', 20)}");
            while (iterator.HasNext())
            {
                Book book = iterator.Next();
                Console.WriteLine($"- {book.Name}");
            }

            Console.ReadLine();
        }
    }
}