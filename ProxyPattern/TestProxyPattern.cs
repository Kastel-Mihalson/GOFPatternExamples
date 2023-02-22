namespace ProxyPattern
{
    public class TestProxyPattern
    {
        public void Execute()
        {
            // Без использования Proxy
            //IChief chief = new Chief();

            // Использование Proxy
            IChief chief = new ProxyChief(new Chief());

            while (true)
            {
                Console.WriteLine($"Today: {DateTime.Now:dd.MM.yyy HH:mm:ss}");
                Console.WriteLine($"Order:\t\tStatus:\n{new string('-', 50)}");
                foreach (var order in chief.GetOrders())
                {
                    var status = chief.GetStatuses().First(i => i.Key == order.Status).Value;
                    Console.WriteLine($"{order.Name}\t\t{status}");
                }

                Thread.Sleep(TimeSpan.FromSeconds(2));
                Console.Clear();
            }
        }
    }
}