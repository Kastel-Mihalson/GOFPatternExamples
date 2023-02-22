namespace AdapterPattern
{
    public class USBStorage : IUSBStoragePort
    {
        public void InsertUSB()
        {
            Console.WriteLine("- Подключено новое устройство: USB flash -");
        }
    }
}