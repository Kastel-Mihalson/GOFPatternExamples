namespace StrategyPattern
{
    public class SimpleGun : ISpaceshipGun
    {
        public string Info { get; set; }
        public SimpleGun()
        {
            Info = "SIMPLE GUN - RAZOR";
        }
        public void Fire()
        {
            Console.WriteLine("Та-та-тат!");
        }
    }
}