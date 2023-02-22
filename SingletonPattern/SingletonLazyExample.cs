namespace SingletonPattern
{
    public class SingletonLazyExample
    {
        private static readonly Lazy<SingletonLazyExample> Instance =
            new Lazy<SingletonLazyExample>(new SingletonLazyExample());

        private static DateTime InstanceCreatedDateTime { get; set; }
        private SingletonLazyExample() => InstanceCreatedDateTime = DateTime.Now;
        
        public static SingletonLazyExample GetInstance() => Instance.Value;

        public DateTime GetCreatedDateTime() => InstanceCreatedDateTime;
    }
}
