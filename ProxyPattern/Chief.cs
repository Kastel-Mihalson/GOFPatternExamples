namespace ProxyPattern
{
    public class Chief : IChief
    {
        public IDictionary<byte, string> GetStatuses()
        {
            var statuses = new Dictionary<byte, string>
            {
                { 1, "Preparing" },
                { 2, "Ready" },
                { 3, "Not ready" }
            };

            // Имитация долгой работы Ресурса получения данных
            Thread.Sleep(TimeSpan.FromSeconds(2));

            return statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            var orders = new List<Order>
            {
                new Order { Name = "Burger", Status = RandomStatus() },
                new Order { Name = "Pasta", Status = RandomStatus() },
                new Order { Name = "Omlete", Status = RandomStatus() }
            };

            return orders;
        }

        private int RandomStatus() => new Random().Next(1, 4);
    }
}