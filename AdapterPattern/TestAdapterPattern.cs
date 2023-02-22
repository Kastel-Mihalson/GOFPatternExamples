namespace AdapterPattern
{
    public class TestAdapterPattern
    {
        public void Execute()
        {
            var laptop = new Laptop();
            var usb = new USBStorage();
            var microSD = new MicroSDCardStorage();
            var stranger = new SomeStrangeStorage();

            var adapter = new MicroSDCardToUSBPortAdaper(microSD);
            var otherAdapter = new SomeStrangeStorageToUSBPortAdapter(stranger);

            laptop.Conect(usb);
            laptop.Conect(adapter);
            laptop.Conect(otherAdapter);
        }
    }
}