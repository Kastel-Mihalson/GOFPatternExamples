namespace DecoratorPattern
{
    public class SimpleGun : Gun
    {
        public SimpleGun() : base("SIMPLE GUN - RAZOR") { }

        public override float GetDamage()
        {
            return 90;
        }

        public override float GetWeight()
        {
            return 9;
        }
    }
}