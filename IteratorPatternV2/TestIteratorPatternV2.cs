namespace IteratorPatternV2
{
    public class TestIteratorPatternV2
    {
        public void Execute()
        {
            var books = new Book[]
            {
                new Book { Name = "Чистая архитектура" },
                new Book { Name = "Шаблоны проектирования" },
                new Book { Name = "Программирования для чайников" },
            };

            var aggregate = new ConcreteAggregate<Book>(books);
            var iterator = aggregate.CreateIterator();

            Console.WriteLine("Использование итератора V2.");
            Console.WriteLine("============================");
            while(!iterator.IsDone())
            {
                Console.WriteLine($"- {iterator.CurrentItem().Name}");
                iterator.Next();
            }
            Console.ReadLine();
        }
    }

    public class Book
    {
        public string Name { get; set; }
    }
}
