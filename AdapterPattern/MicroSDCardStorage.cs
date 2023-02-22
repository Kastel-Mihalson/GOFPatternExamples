namespace AdapterPattern
{
    public class MicroSDCardStorage : IMicroSDCardPort
    {
        public void InsertMicroSD()
        {
            Console.WriteLine("- Подключено новое устройство: MicroSD Card -");
        }
    }
}