using System.ComponentModel;

namespace SingletonPattern
{
    public class SingletonExample
    {
        private static SingletonExample Instance { get; set; }

        private static DateTime InstanceCreatedDateTime { get; set; }

        private SingletonExample() { }

        public static SingletonExample GetInstance()
        {
            if (Instance == null)
            {
                InstanceCreatedDateTime = DateTime.Now;
                Instance = new SingletonExample();
            }
            return Instance;
        }

        public DateTime GetCreatedDateTime()
        {
            return InstanceCreatedDateTime;
        }
    }
}