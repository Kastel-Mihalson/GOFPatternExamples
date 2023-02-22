namespace StrategyPattern
{
    public class SnowballGun : ISpaceshipGun
    {
        public string Info { get; set; }

        public SnowballGun()
        {
            Info = "SNOWBALL GUN - ICE BABY";
        }
        public void Fire()
        {
            Console.WriteLine("Фух-фух!");
        }
    }
}