namespace StrategyPattern
{
    public class LaserGun : ISpaceshipGun
    {
        public string Info { get; set; }
        public LaserGun()
        {
            Info = "LASER GUN - IMPULSE";
        }
        public void Fire()
        {
            Console.WriteLine("Пиу-пиу!");
        }
    }
}