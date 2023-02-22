namespace SingletonPattern
{
    public class SingletionLockExample
    {
        private static SingletionLockExample Instance { get; set; }
        private static DateTime InstanceCreatedDateTime { get; set; }

        private static object locker = new object();

        private SingletionLockExample() { }

        public static SingletionLockExample GetInstance()
        {
            if (Instance == null)
            {
                lock (locker)
                {
                    if (Instance == null)
                    {
                        InstanceCreatedDateTime = DateTime.Now;
                        Instance = new SingletionLockExample();
                    }
                }
            }
            return Instance;
        }

        public DateTime GetCreatedDateTime()
        {
            return InstanceCreatedDateTime;
        }
    }
}
