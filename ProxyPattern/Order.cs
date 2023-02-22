namespace ProxyPattern
{
    public struct Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            Name = "None";
            Status = 0;
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public int Status { get; set; }
    }
}