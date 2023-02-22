namespace DecoratorPattern
{
    public class LaserGun : Gun
    {
        public LaserGun() : base("LASER GUN - IMPULSE") { }

        public override float GetDamage()
        {
            return 120;
        }

        public override float GetWeight()
        {
            return 12;
        }
    }
}