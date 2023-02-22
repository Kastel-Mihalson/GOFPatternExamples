using System.Threading;

namespace SingletonPattern
{
    public class TestSingletonPattern
    {
        public void Execute()
        {
            Console.WriteLine("Simple singleton example: (created second instance after 1 second.)");
            SingletonExample instance = SingletonExample.GetInstance();
            var dt = instance.GetCreatedDateTime();
            Console.WriteLine(dt);

            Thread.Sleep(TimeSpan.FromSeconds(1));

            SingletonExample instanceOther = SingletonExample.GetInstance();
            var dt2 = instanceOther.GetCreatedDateTime();
            Console.WriteLine(dt2);

            Console.WriteLine();
            Console.WriteLine("Lock singleton example:");
            var instanceF = SingletionLockExample.GetInstance();
            var dtF = instanceF.GetCreatedDateTime();
            Console.WriteLine(dtF);

            Thread.Sleep(TimeSpan.FromSeconds(1));

            var instanceS = SingletionLockExample.GetInstance();
            var dtS = instanceS.GetCreatedDateTime();
            Console.WriteLine(dtS);

            Console.WriteLine();
            Console.WriteLine("Lazy singleton example:");
            var lazyInstanceF = SingletonLazyExample.GetInstance();
            var lDtF = lazyInstanceF.GetCreatedDateTime();
            Console.WriteLine(lDtF);

            Thread.Sleep(TimeSpan.FromSeconds(1));

            var lazyInstanceS = SingletonLazyExample.GetInstance();
            var lDtS = lazyInstanceS.GetCreatedDateTime();
            Console.WriteLine(lDtS);
        }
    }
}