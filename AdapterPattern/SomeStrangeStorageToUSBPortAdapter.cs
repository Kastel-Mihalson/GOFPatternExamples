namespace AdapterPattern
{
    public class SomeStrangeStorageToUSBPortAdapter : IUSBStoragePort
    {
        private ISomeStrangeStoragePort _strangeStorage;

        public SomeStrangeStorageToUSBPortAdapter(ISomeStrangeStoragePort strangeStorage)
        {
            _strangeStorage = strangeStorage;
        }

        public void InsertUSB()
        {
            _strangeStorage.InsertSomeSrtrange();
        }
    }
}
