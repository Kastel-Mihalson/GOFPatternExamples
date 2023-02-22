namespace AdapterPattern
{
    public class MicroSDCardToUSBPortAdaper : IUSBStoragePort
    {
        private IMicroSDCardPort _microSD;

        public MicroSDCardToUSBPortAdaper(IMicroSDCardPort microSD)
        {
            _microSD = microSD;
        }
        public void InsertUSB()
        {
            _microSD.InsertMicroSD();
        }
    }
}