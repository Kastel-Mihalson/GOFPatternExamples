namespace AdapterPattern
{
    public class SomeStrangeStorage : ISomeStrangeStoragePort
    {
        public void InsertSomeSrtrange()
        {
            Console.WriteLine("- Подключено новое устройство: Some strange storage -");
        }
    }
}
