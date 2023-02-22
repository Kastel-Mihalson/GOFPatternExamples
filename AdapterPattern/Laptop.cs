namespace AdapterPattern
{
    public class Laptop
    {
        public void Conect(IUSBStoragePort usbPort)
        {
            usbPort.InsertUSB();
        }
    }
}