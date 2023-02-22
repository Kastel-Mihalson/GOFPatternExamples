namespace ProxyPattern
{
    public class ProxyChief : IChief
    {
        private Chief _chief;
        private IDictionary<byte, string> _statuses;

        public ProxyChief(Chief chief)
        {
            _chief = chief;
        }

        public IDictionary<byte, string> GetStatuses()
        {
            // Кешируем статус
            if (_statuses is null)
            {
                _statuses = _chief.GetStatuses();
            }
            return _statuses;
        }

        public IEnumerable<Order> GetOrders()
        {
            return _chief.GetOrders();
        }
    }
}