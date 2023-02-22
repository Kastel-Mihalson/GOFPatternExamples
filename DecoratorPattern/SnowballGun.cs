namespace DecoratorPattern
{
    public class SnowballGun : Gun
    {
        public SnowballGun() : base("SNOWBALL GUN - ICE BABY")
        {
            Console.WriteLine("SNOWBALL GUN - ICE BABY");
        }
        public override float GetDamage()
        {
            return 100;
        }

        public override float GetWeight()
        {
            return 10;
        }
    }
}