namespace ProxyPattern
{
    public interface IChief
    {
        IDictionary<byte, string> GetStatuses();
        IEnumerable<Order> GetOrders();
    }
}